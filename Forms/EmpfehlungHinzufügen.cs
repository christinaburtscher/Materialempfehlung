using Materialempfehlung.Models;
using Materialempfehlung.Repository;

namespace Materialempfehlung
{
    public partial class EmpfehlungHinzufügen : Form
    {
        private readonly EmpfehlungenRepository? _empfehlungenRepository;
        private readonly MaterialRepository? _materialRepository;
        private readonly int _preisartikel;

        public EmpfehlungHinzufügen()
        {
            InitializeComponent();
            _empfehlungenRepository = new EmpfehlungenRepository();
            if (_empfehlungenRepository == null)
            {
                throw new NotImplementedException();
            }

            _materialRepository = new MaterialRepository();
            if (_materialRepository == null)
            {
                throw new NotImplementedException();
            }
        }

        public EmpfehlungHinzufügen(MaterialVorschlag vorschlag, string bereich, List<string> bestehendeEmpfehlungen)
        {
            InitializeComponent();
            _empfehlungenRepository = new EmpfehlungenRepository();
            if (_empfehlungenRepository == null)
            {
                throw new NotImplementedException();
            }

            _materialRepository = new MaterialRepository();
            if (_materialRepository == null)
            {
                throw new NotImplementedException();
            }

            textBoxEmpfehlungHinzufügenBereich.Text = bereich;
            _preisartikel = vorschlag.Preisartikel;

            //alle Felder Empfehlungen abholen
            var empfehlungen = _empfehlungenRepository?.GetAllForOverview(bereich);
            var values = empfehlungen?.Values.FirstOrDefault();
            if (values == null || values.Count <= 0)
            {
                errorProviderEmpfehlungHinzufügen.SetError(textBoxEmpfehlungHinzufügenBereich, "Felder können nicht geladen werden. Bitte erneut probieren");
                return;
            }

            var nochVerfügbareEmpfehlungen = values.Except(bestehendeEmpfehlungen).ToList();
            listBoxEmpfehlungHinzufügenAuswahl.DataSource = nochVerfügbareEmpfehlungen;
        }

        private void ButtonHinzufügen_Click(object sender, EventArgs e)
        {
            var bereich = textBoxEmpfehlungHinzufügenBereich.Text;
            var selectedItems = listBoxEmpfehlungHinzufügenAuswahl.SelectedItems.Cast<string>().ToList();
            foreach (var item in selectedItems)
            {
                var result = _materialRepository?.AddRelation(_preisartikel, bereich, item) ?? false;
                if (!result)
                {
                    errorProviderEmpfehlungHinzufügen.SetError(textBoxEmpfehlungHinzufügenBereich, "Verbindung konnte nicht hinzugefügt werden. Bitte erneut probieren");
                    return;
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
