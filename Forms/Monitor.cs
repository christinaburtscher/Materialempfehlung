using Materialempfehlung.Repository;
using System.DirectoryServices.AccountManagement;

namespace Materialempfehlung
{
    public partial class Monitor : Form
    {
        private readonly UserRepository _userRepository;
        private readonly MaterialRepository _materialRepository;
        private readonly Materialübersicht _materialÜbersicht;

        public Monitor()
        {
            InitializeComponent();

            _userRepository = new UserRepository();
            if (_userRepository == null)
            {
                throw new NotImplementedException();
            }

            _materialRepository = new MaterialRepository();
            if (_materialRepository == null)
            {
                throw new NotImplementedException();
            }

            _materialÜbersicht = new Materialübersicht
            {
                Dock = DockStyle.Fill
            };

            tabControlMonitor.SelectedTab = tabPageMaterial;
            splitContainer1.Panel2.Controls.Add(_materialÜbersicht);

            //Empfehlungen im Testbetrieb anzeigen
            string[] startparameter = Environment.GetCommandLineArgs();
            string username;
            if (startparameter.Length > 1)
            {
                username = startparameter[2];
            }
            else
            {
                username = "christina.burtscher";
            }

            var result = _userRepository.GetAbteilung(username);
            var abteilung = result.Values.Cast<string>().FirstOrDefault();
            if (!string.IsNullOrEmpty(abteilung) && abteilung.Equals("IT", StringComparison.OrdinalIgnoreCase))
            {
                //Empfehlungen können bearbeitet werden
                LoginErfolgreich(result.Keys.FirstOrDefault());
                var empfehlungenControl = new Empfehlungen
                {
                    Dock = DockStyle.Fill
                };
                tabPageEmpfehlungen_Admin.Controls.Add(empfehlungenControl);
            }
        }

        private Dictionary<string, string>? UserInformationen(string username)
        {
            var result = new Dictionary<string, string>();
            PrincipalContext pc = new(ContextType.Domain, "cariniat");
            if (pc.ValidateCredentials(username, textBoxPasswort.Text))
            {
                result = _userRepository.GetAbteilung(textBoxUser.Text);
                if (result != null)
                {
                    LoginErfolgreich(result.Keys.FirstOrDefault());
                }
                else
                {
                    Login_fehlerhaft();
                    MessageBox.Show("Username oder Passwort falsch.");
                }
            }
            else
            {
                Login_fehlerhaft();
                MessageBox.Show("Username oder Passwort falsch.");
            }

            return result;
        }
        private void ButtonVorauswahl_Click(object sender, EventArgs e)
        {
            var artikelnummer = textBoxVorauswahl.Text;
            if (string.IsNullOrEmpty(artikelnummer))
            {
                errorProviderVorauswahl.SetError(textBoxVorauswahl, "Keine Artikelnummer. Bitte Nummer eingeben");
                return;
            }
            if (artikelnummer.Length < 3)
            {
                errorProviderVorauswahl.SetError(textBoxVorauswahl, "Artikelnummer zu kurz für Suchvorschläge. Bitte mindestens 3 Zeichen eingeben");
                return;
            }
            var vorschläge = _materialRepository.Vorauswahl(artikelnummer);
            if (vorschläge.Count <= 0)
            {
                errorProviderVorauswahl.SetError(textBoxVorauswahl, "Keine Vorschläge gefunden");
            }

            _materialÜbersicht.LoadMaterial(vorschläge);
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            PrincipalContext pc = new(ContextType.Domain, "cariniat");
            if (pc.ValidateCredentials(textBoxUser.Text, textBoxPasswort.Text))
            {
                var abteilung = UserInformationen(textBoxUser.Text);
                if (abteilung.ContainsKey(textBoxUser.Text))
                {
                    LoginErfolgreich(abteilung.Keys.FirstOrDefault());
                }
            }
            else
            {
                Login_fehlerhaft();
                MessageBox.Show("Username oder Passwort falsch.");
            }
        }

        private void LoginErfolgreich(string username)
        {
            textBoxUser.Text = username;
            buttonLogin.Visible = false;
            labelPasswort.Visible = false;
            textBoxPasswort.Visible = false;
            buttonVorauswahl.Visible = true;
        }

        private void Login_fehlerhaft()
        {
            textBoxUser.Text = "";
            textBoxPasswort.Text = "";

            buttonLogin.Visible = true;
            labelPasswort.Visible = true;
            textBoxPasswort.Visible = true;
            buttonVorauswahl.Visible = true;

            buttonVorauswahl.Visible = false;
        }
    }
}