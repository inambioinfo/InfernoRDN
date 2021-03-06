using System;
using System.Globalization;
using System.Windows.Forms;
using DAnTE.Properties;

namespace DAnTE.Inferno
{
    public partial class frmZRollupPar : Form
    {
        readonly Purgatorio.clsZRollupPar mclsZRollup;
        private bool fieldsOK = true;

        public frmZRollupPar(Purgatorio.clsZRollupPar mclsZRoll)
        {
            InitializeComponent();
            mclsZRollup = mclsZRoll;
        }

        private void mbtnOK_Click(object sender, EventArgs e)
        {
            float gpvalue = 0.05f, minPresence = 50.0f;

            if (mtxtBoxGminP.Text.Length == 0 && mtxtBoxGpval.Text.Length == 0 &&
                mtxtBoxMinPresent.Text.Length == 0)
                fieldsOK = false;
            else
            {
                try
                {
                    minPresence = Convert.ToSingle(MinPresence, NumberFormatInfo.InvariantInfo);
                    gpvalue = Convert.ToSingle(Gp_value, NumberFormatInfo.InvariantInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data type error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fieldsOK = false;
                }
                if (minPresence < 0 || minPresence > 100 || gpvalue > 1 || gpvalue < 0)
                {
                    fieldsOK = false;
                    MessageBox.Show("Out of allowed range.", "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            if (fieldsOK)
                DialogResult = DialogResult.OK;
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void mbtnDefaults_Click(object sender, EventArgs e)
        {
            mtxtBoxGminP.Text = "5";
            mtxtBoxGpval.Text = "0.2";
            mchkBoxOneHit.Checked = false;
            mtxtBoxMinPresent.Text = "50";
        }

        private void mchkBoxPlot_CheckedChanged(object sender, EventArgs e)
        {
            if (mchkBoxPlot.Checked)
            {
                mtxtBoxFolder.Enabled = true;
                mbtnSelectFolder.Enabled = true;
            }
            else
            {
                mtxtBoxFolder.Enabled = false;
                mbtnSelectFolder.Enabled = false;
            }
        }

        private void mbtnSelectFolder_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();
            var result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var folderName = folderBrowserDialog1.SelectedPath;
                mtxtBoxFolder.Text = folderName;
            }
            else mtxtBoxFolder.Text = Settings.Default.WorkingFolder;
        }

        private void mtxtBoxGminP_TextChanged(object sender, EventArgs e)
        {
            int grubbsMinP;
            try
            {
                grubbsMinP = Convert.ToInt16(mtxtBoxGminP.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data type error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }
            if (grubbsMinP < 3)
            {
                MessageBox.Show(
                    "Setting the minimum number of peptides for Grubb's test too low may not be a good idea.",
                    "Peptides for Grubb's too low", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtBoxGminP.Text = "5";
            }
        }

        private void frmZRollupPar_Load(object sender, EventArgs e)
        {
            this.DataSetName = mclsZRollup.DataSetName;
            this.OutFolder = mclsZRollup.OutFolder_pub;
        }

        #region Properties

        public Purgatorio.clsZRollupPar clsZRollupPar
        {
            get
            {
                mclsZRollup.mstrMinPresence = MinPresence;
                mclsZRollup.mblOneHits = OneHitWonders;
                mclsZRollup.OutFolder_pub = OutFolder.Replace("\\", "/") + "/";
                mclsZRollup.mblPlot = PlotFlag;
                mclsZRollup.mstrGrubsNum = gminPCount;
                mclsZRollup.mstrGrubsP = Gp_value;
                mclsZRollup.mblModeMean = ModeMean;

                return mclsZRollup;
            }
        }

        public string MinPresence => mtxtBoxMinPresent.Text;

        public bool OneHitWonders => mchkBoxOneHit.Checked;

        public string Gp_value => mtxtBoxGpval.Text;

        public string gminPCount => mtxtBoxGminP.Text;

        public string OutFolder
        {
            get => mtxtBoxFolder.Text;
            set => mtxtBoxFolder.Text = value;
        }

        public bool DoPlotting => mchkBoxPlot.Checked;

        public bool PlotFlag => DoPlotting;

        public string DataSetName
        {
            set => mlblDataName.Text = value;
        }

        public bool ModeMean => mchkBoxMode.Checked;

        #endregion
    }
}