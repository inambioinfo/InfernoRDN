using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DAnTE.Properties;
using DAnTE.Tools;

namespace DAnTE.Inferno
{
    public partial class frmAnalysisSummary : Form
    {
        private List<clsAnalysisObject> marrAnalyses = new List<clsAnalysisObject>();
        private string mstrFileName;

        private readonly string mstrTime;

        public frmAnalysisSummary()
        {
            InitializeComponent();
            mstrTime = DateTime.Now.ToString("G", System.Globalization.CultureInfo.CreateSpecificCulture("en-us"));
        }


        private void FillSummaryListView()
        {
            mlstViewSummary.Columns.Add("Parameter", 200, HorizontalAlignment.Left);
            mlstViewSummary.Columns.Add("Value", 350, HorizontalAlignment.Left);

            foreach (var analysis in marrAnalyses)
            {
                var o = analysis.AnalysisObject;
                var strKey = analysis.Operation;

                var grp = new ListViewGroup(strKey, HorizontalAlignment.Left);
                mlstViewSummary.Groups.Add(grp);

                var props = o.GetType().GetProperties();
                foreach (var prop in props)
                {
                    try
                    {
                        var customAttributes = prop.GetCustomAttributes(typeof(clsAnalysisAttribute), true);
                        if (customAttributes.Length <= 0 || !prop.CanRead)
                        {
                            continue;
                        }

                        var attr = customAttributes[0] as clsAnalysisAttribute;
                        var objectValue = prop.GetValue(o, System.Reflection.BindingFlags.GetProperty,
                                                        null, null, null);
                        if (objectValue == null || attr == null)
                        {
                            continue;
                        }

                        var tmpItem = new ListViewItem(attr.Description, grp);
                        tmpItem.SubItems.Add(objectValue.ToString());
                        mlstViewSummary.Items.Add(tmpItem);
                    }
                    catch
                    {
                        // Ignore exceptions here
                    }
                }
                foreach (var field in o.GetType().GetFields())
                {
                    try
                    {
                        var customAttributes = field.GetCustomAttributes(typeof(clsAnalysisAttribute), true);
                        if (customAttributes.Length > 0)
                        {
                            var attr = customAttributes[0] as clsAnalysisAttribute;
                            var objectValue = field.GetValue(o);
                            if (objectValue == null || attr == null)
                            {
                                continue;
                            }

                            var tmpItem = new ListViewItem(attr.Description, grp);
                            tmpItem.SubItems.Add(objectValue.ToString());
                            mlstViewSummary.Items.Add(tmpItem);
                        }
                    }
                    catch
                    {
                        // Ignore exceptions here
                    }
                }
            }
        }

        private MetaData FillSummaryXML()
        {
            var metaData = new MetaData("DAnTE_Analysis");
            metaData.SetValue("DataFile", mstrFileName);
            metaData.SetValue("Time", mstrTime);

            foreach (var analysis in marrAnalyses)
            {
                var o = analysis.AnalysisObject;
                var strKey = analysis.Operation;

                var metaNode = metaData.OpenChild(strKey);

                var props = o.GetType().GetProperties();
                foreach (var prop in props)
                {
                    try
                    {
                        var customAttributes = prop.GetCustomAttributes(typeof(clsAnalysisAttribute), true);
                        if (customAttributes.Length <= 0 || !prop.CanRead)
                        {
                            continue;
                        }

                        var attr = customAttributes[0] as clsAnalysisAttribute;
                        var objectValue = prop.GetValue(o, System.Reflection.BindingFlags.GetProperty,
                                                        null, null, null);
                        if (objectValue != null && attr != null)
                        {
                            metaNode.SetValue(attr.Description, objectValue.ToString());
                        }
                    }
                    catch
                    {
                        return null;
                    }
                }

                foreach (var field in o.GetType().GetFields())
                {
                    try
                    {
                        var customAttributes = field.GetCustomAttributes(typeof(clsAnalysisAttribute), true);
                        if (customAttributes.Length <= 0)
                        {
                            continue;
                        }

                        var attr = customAttributes[0] as clsAnalysisAttribute;
                        var objectValue = field.GetValue(o);
                        if (objectValue != null && attr != null)
                        {
                            metaNode.SetValue(attr.Description, objectValue.ToString());
                        }
                    }
                    catch
                    {
                        return null;
                    }
                }
            }
            return metaData;
        }


        private void frmAnalysisSummary_Load(object sender, EventArgs e)
        {
            FillSummaryListView();
            mlblTime.Text = mstrTime;
            mlblDataFile.Text = mstrFileName;
        }


        private void mBtnSave_Click(object sender, EventArgs e)
        {
            var fileName = GetSaveFileName("Select a file to save summary",
                                           "XML files (*.xml)|*.xml|Tab delimited txt files (*.txt)|*.txt");
            var fExt = System.IO.Path.GetExtension(fileName);

            if (fileName == null || fExt == null)
            {
                return;
            }

            if (fExt.Equals(".xml", StringComparison.CurrentCultureIgnoreCase))
            {
                var metaDataXML = FillSummaryXML();
                metaDataXML?.WriteFile(fileName);
            }

            if (fExt.Equals(".txt", StringComparison.CurrentCultureIgnoreCase))
            {
                using (System.IO.TextWriter streamWriter = new System.IO.StreamWriter(fileName))
                {
                    CsvWriter.WriteListViewToStream(streamWriter, mlstViewSummary,
                                                    mstrFileName, false);
                }
            }
        }

        private string GetSaveFileName(string mstrFldgTitle, string filter)
        {
            var workingFolder = Settings.Default.WorkingFolder;
            string fileName;

            var fdlg = new SaveFileDialog
            {
                Title = mstrFldgTitle,
                InitialDirectory = workingFolder ?? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Filter = filter,
                FilterIndex = 1,
                RestoreDirectory = false
            };


            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fileName = fdlg.FileName;
                workingFolder = System.IO.Path.GetDirectoryName(fileName);
                Settings.Default.WorkingFolder = workingFolder;
                Settings.Default.Save();
            }
            else
                fileName = null;

            return fileName;
        }

        #region Properties

        public List<clsAnalysisObject> SummaryArrayList
        {
            set => marrAnalyses = value;
        }

        public string DataFileName
        {
            set => mstrFileName = value;
        }

        #endregion
    }
}