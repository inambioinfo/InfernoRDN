using System.Collections.Generic;

namespace DAnTE.Purgatorio
{
    public class clsAnovaPar
    {
        private string rcmd;
        [Tools.clsAnalysisAttribute("Check_for_Unbalance_Data", "ANOVA")] public bool unbalanced;
        public bool randomE;
        [Tools.clsAnalysisAttribute("Use_Restricted_Maximum_Likelihood", "ANOVA")] public bool useREML;
        [Tools.clsAnalysisAttribute("Check_Interactions", "ANOVA")] public bool interactions;
        //[Tools.clsAnalysisAttribute("Dataset(R)", "ANOVA")]
        public string Rdataset;
        [Tools.clsAnalysisAttribute("Source_DataTable", "ANOVA")] public string mstrDatasetName;
        [Tools.clsAnalysisAttribute("Minimum_Datapoints_Needed", "ANOVA")] public int numDatapts;
        public List<string> fixedEff;
        public List<string> randomEff;

        public clsAnovaPar()
        {
            unbalanced = false;
            randomE = false;
            useREML = false;
            interactions = false;
            Rdataset = "Eset";
            numDatapts = 3;
            fixedEff = new List<string>();
            randomEff = new List<string>();
        }

        public string Rcmd
        {
            get
            {
                rcmd = "anovaR <- DoAnova(" + Rdataset + ",FixedEffects=" + FixedEffects +
                       ",RandomEffects=" + RandomEffects + ",thres=" + numDatapts + "," +
                       Interactions + "," + Unbalanced + "," + UseREML + ")";
                return rcmd;
            }
        }

        [Tools.clsAnalysisAttribute("Fixed_Effect_Factors", "ANOVA")]
        public string FixedEffectsFactors
        {
            get
            {
                string fEff;

                if (fixedEff.Count == 0)
                    return "None";
                else
                    fEff = fixedEff[0];

                for (var i = 1; i < fixedEff.Count; i++)
                {
                    fEff = fEff + "," + fixedEff[i];
                }

                return fEff;
            }
        }

        private string FixedEffects
        {
            get
            {
                string fEff;

                if (fixedEff.Count == 0)
                    return "NULL";
                else
                    fEff = @"c(""" + fixedEff[0] + @"""";

                for (var i = 1; i < fixedEff.Count; i++)
                {
                    fEff = fEff + @",""" + fixedEff[i] + @"""";
                }
                fEff = fEff + ")";

                return fEff;
            }
        }

        [Tools.clsAnalysisAttribute("Random_Effect_Factors", "ANOVA")]
        public string RandomEffectsFactors
        {
            get
            {
                string rEff;

                if (randomEff.Count == 0)
                    return "None";
                else
                    rEff = randomEff[0];

                for (var i = 1; i < randomEff.Count; i++)
                {
                    rEff = rEff + "," + randomEff[i];
                }

                return rEff;
            }
        }

        private string RandomEffects
        {
            get
            {
                string rEff;

                if (randomEff.Count == 0)
                    return "NULL";
                else
                    rEff = @"c(""" + randomEff[0] + @"""";

                for (var i = 1; i < randomEff.Count; i++)
                {
                    rEff = rEff + @",""" + randomEff[i] + @"""";
                }
                rEff = rEff + ")";

                return rEff;
            }
        }

        private string UseREML
        {
            get
            {
                if (useREML)
                    return "useREML=TRUE";
                else
                    return "useREML=FALSE";
            }
        }

        private string Interactions
        {
            get
            {
                if (interactions)
                    return "interact=TRUE";
                else
                    return "interact=FALSE";
            }
        }

        private string Unbalanced
        {
            get
            {
                if (unbalanced)
                    return "unbalanced=TRUE";
                else
                    return "unbalanced=FALSE";
            }
        }
    }
}