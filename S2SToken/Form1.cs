

using Microsoft.Identity.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace S2SToken
{
    public partial class Form1 : Form
    {
        private const string historyFile = "history.json";
        private TokenHistory _history;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var clientId = this.clientIdTextBox.Text.Trim();
            var clientSecret = this.clientSecretTextBox.Text.Trim();
            var resourceId = this.resourceIdTextBox.Text.Trim();
            var authority = this.authorityTextBox.Text.Trim();
            TaskScheduler syncSch = TaskScheduler.FromCurrentSynchronizationContext();
            Task.Run(async Task<string?>? () => await GetToken(clientId, clientSecret, resourceId, authority)
                .ConfigureAwait(false))
                .ContinueWith(task => this.tokenTextBox.Text = task.Result ?? string.Empty, syncSch);
        }

        private static async Task<string> GetToken(string clientId, string clientSecret, string resourceId, string authority)
        {
            var clientApp = ConfidentialClientApplicationBuilder.Create(clientId)
            .WithAuthority(authority)
            .WithClientSecret(clientSecret)
            .Build();
            var tokenBuilder = clientApp.AcquireTokenForClient(new string[] { $"{resourceId}/.default" });//AVEVA-Insight-Common-AzureAD-S2S-Historian-OData-ResourceId

            var token = await tokenBuilder.ExecuteAsync();
            return token.AccessToken;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(historyFile))
            {
                var history = File.ReadAllText(historyFile);
                _history = JsonConvert.DeserializeObject<TokenHistory>(history);
                this.listBox1.DataSource = _history?.History?.Select(x => x.Alias).OrderBy(x => x).ToArray();
            }
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            if (_history == null || _history.History == null)
            {
                _history = new TokenHistory();
                _history.History = new List<GenerateInfo>();
            }

            var alias = this.aliasTextBox.Text.Trim();
            var clientId = this.clientIdTextBox.Text.Trim();
            var clientSecret = this.clientSecretTextBox.Text.Trim();
            var resourceId = this.resourceIdTextBox.Text.Trim();
            var authority = this.authorityTextBox.Text.Trim();

            if (string.IsNullOrEmpty(alias) ||
                string.IsNullOrEmpty(clientId) ||
                string.IsNullOrEmpty(clientSecret) ||
                string.IsNullOrEmpty(resourceId) ||
                string.IsNullOrEmpty(authority))
            {
                MessageBox.Show("Information missing!");
                return;
            }

            var existed = _history.History.Find(x => x.Alias == alias);
            if (existed != null)
            {
                var result = MessageBox.Show($"Are you sure to overwrite {alias}?", "Confirm", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                    return;
                existed.Authority = authority;
                existed.ClientId = clientId;
                existed.ClientSecret = clientSecret;
                existed.ResourceId = resourceId;
            }
            else
            {
                _history.History.Add(new GenerateInfo
                {
                    Alias = alias,
                    Authority = authority,
                    ClientId = clientId,
                    ClientSecret = clientSecret,
                    ResourceId = resourceId
                });
            }

            var hist = JsonConvert.SerializeObject(_history);
            File.WriteAllText(historyFile, hist);
            this.listBox1.DataSource = _history?.History?.Select(x => x.Alias).OrderBy(x => x).ToArray();
            this.listBox1.SelectedItem = alias;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selectedAlias = Convert.ToString(this.listBox1.SelectedItem).Trim();
            var info = this._history.History.Find(x => x.Alias == selectedAlias);
            if (info != null)
            {
                this.aliasTextBox.Text = info.Alias;
                this.clientIdTextBox.Text = info.ClientId;
                this.clientSecretTextBox.Text = info.ClientSecret;
                this.resourceIdTextBox.Text = info.ResourceId;
                this.authorityTextBox.Text = info.Authority;
            }
        }

        private void OnDeleteClick(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem == null)
                return;

            var selectedAlias = Convert.ToString(this.listBox1.SelectedItem).Trim();
            var result = MessageBox.Show($"Are you sure to delete {selectedAlias}?", "Confirm", MessageBoxButtons.OKCancel);
            
            if (result == DialogResult.Cancel)
                return;
            var info = this._history.History.Find(x => x.Alias == selectedAlias);
            if (info != null)
            {
                this._history.History.Remove(info);
            }

            var hist = JsonConvert.SerializeObject(_history);
            File.WriteAllText(historyFile, hist);
            this.listBox1.DataSource = _history?.History?.Select(x => x.Alias).OrderBy(x => x).ToArray();
        }
    }
}