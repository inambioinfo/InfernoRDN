# InfernoRDN

InfernoRDN can perform various downstream analyses on large scale datasets from proteomics and microarrays.

Among many features of InfernoRDN are:
* A set of diagnostic plots (Histograms, boxplots, correlation plots, qq-plots, peptide-protein rollup plots, MA plots, PCA plots, etc).
* Log transforming.
* Rolling up to proteins (3 methods are available).
* LOESS normalization
* Linear Regression Normalization
* Mean Centering
* Median Absolute Deviation (MAD) Adjustment across datasets
* Quantile Normalization
* Principal Component Analysis
* Partial Least Squares Analysis
* ANOVA (multi-way, unbalanced, random effects)
* Heatmaps with Hierarchical and K-means cluster options

InfernoRDN is an updated version of Inferno (which used StatconnDCOM). 
It supersedes all previous DAnTE (Data Analysis Tool Extension), DanteR, and Inferno versions.

InfernoRDN uses R.NET (https://github.com/jmp75/rdotnet) to communicate with R. 


## Installation

1. Download and install the latest version of R 3.x from
   * https://cran.r-project.org/bin/windows/base/

2. Download the InfernoRDN installer from either of these sites:
   * https://github.com/PNNL-Comp-Mass-Spec/InfernoRDN/releases
   * https://omics.pnl.gov/software/infernordn

3. Run the installer, InfernoRDNSetup.exe

4. Start InfernoRDN using the Start Menu or desktop shortcut

5. The InfernoRDN splash screen will appear and status messages will be shown
   * If a Dialog box appears asking "Would you like to use a personal library"
    you should answer Yes to that question, and Yes to the next question
    regarding the folder to use for the personal library
   * Following this, several Bioconductor packages will be downloaded

6. Test loading a data file	
   * Choose File, Open, Expression File
   * Navigate to "C:\Program Files (x86)\InfernoRDN\Sample_Data_Files"
   * Select SampleInput4DAnTE.csv and click Open
   * Choose column Mass_Tag_ID then click the ">>" button to the left (and just below) "Unique Row ID"
   * Enable checkbox "Protein ID"
   * Select column MinOfOrf then click the ">>" button to the left (and just below) "Protein ID" 
   * Select data columns P10A through P19B then click the ">>" button to the left (and below) "Data Columns" 
   * Click OK

7. Test the plotting
   * Choose Plot, Correlation
   * Enable checkbox Toggle All, then click OK

## Dependencies

InfernoRDN depends on the following:
1. Windows 7 (or newer) with the .NET 4.6 framework or newer
   * https://www.microsoft.com/en-us/download/details.aspx?id=53344

2. R Statistical Environment, version 3.0 or newer
   * https://cran.r-project.org/bin/windows/base/

### R Packages

InfernoRDN uses the following R packages (from https://cran.r-project.org/):
* amap: Another Multidimensional Analysis Package
* car: Companion to Applied Regression
* nlme: Linear and Nonlinear Mixed Effects Models
* outliers: Tests for outliers
* fpc: Fixed point clusters, clusterwise regression and discriminant plots
* pls: Partial Least Squares Regression (PLSR) and Principal Component Regression (PCR)
* MASS: Main Package of Venables and Ripley's MASS
* impute: Imputation for microarray data
* qvalue: Q-value estimation for false discovery rate control
* e1071: Misc Functions of the Department of Statistics (e1071), TU Wien
* ggplot2: Various R programming tools for plotting data
* ellipse: Functions for drawing ellipses and ellipse-like confidence regions
* plotrix: Various plotting functions
* scatterplot3d: 3D Scatter Plot
* colorspace: Colorspace Manipulation
* Hmisc: Harrell Miscellaneous
* Cairo: R graphics device using cairo graphics library

The packages will be installed to either the library folder in `C:\Program Files\R\R-3.x.x\library` or, more likely (due to permissions) to the `R\win-library` folder in your "Documents" or "My Documents" folder.

## Factor Definitions File

Factors can be defined using the GUI, or by loading a text file listing the factors 
to associate with each dataset (column name) in the expressions table.

A factor definitions file can be a CSV file (comma-separated) or a .txt file (tab-separated)

The first row of the factor definitions file must have a column named Factor, 
then column names that match the names in the originally loaded Expressions table. 
Each subsequent row of the factor file is a new factor name, then the factor value for each dataset.

The following shows example rows of a factor definitions file (tab-separated). 
There are 6 datasets and two factors (Time and Temperature) defined for each dataset.

Factor | P10A | P10B | P11A | P11B | P12A | P12B
------ | ---- | ---- | ---- | ---- | ---- | ----
Time | 0 | 0 | 5 | 5 | 10 | 10
Temperature | Hot | Cold | Hot | Cold | Hot | Cold

## Manuscript

Polpitiya AD, Qian WJ, Jaitly N, Petyuk VA, Adkins JN, Camp DG 2nd, Anderson GA, Smith RD., 
DAnTE: a statistical tool for quantitative analysis of -omics data. 
Bioinformatics. 2008 Jul 1;24(13):1556-1558. 
https://www.ncbi.nlm.nih.gov/pubmed/?term=18453552

## Contacts

Developed by Ashoka Polpitiya for the US Department of Energy and TGen\
Includes contributions from Gary Kiebel and Matthew Monroe at PNNL\
PNNL, Richland, WA, USA.\
TGen, Phoenix, AZ, USA.

Copyright 2007, 2014, Battelle Memorial Institute.  All Rights Reserved.\
Copyright 2010, Translational Genomics Research Institute.  All Rights Reserved.

E-mail: matthew.monroe@pnnl.gov or ashoka@tgen.org\
Website: http://omics.pnl.gov/software/InfernoRDN

## License

InfernoRDN is licensed under the Apache License, Version 2.0; you may not use 
this file except in compliance with the License.  You may obtain a copy of 
the License at http://www.apache.org/licenses/LICENSE-2.0

All publications that result from the use of this software 
should include the following acknowledgment statement: 
> Portions of this research were supported by NIH, DOE, and Pacific Northwest National Laboratory (PNNL), 
> in addition to the Center for Proteomics, Translational Genomics Research Institute (TGEN).

However, if the software is extended or modified, any subsequent publications 
should include a more extensive statement, using this text or a similar variant: 
> Portions of this research were supported by the 
> National Institute of General Medical Sciences (NIGMS, Large Scale Collaborative Research Grants U54 GM-62119-02), 
> the NIH National Center for Research Resources (RR18522), and 
> the National Institute of Allergy and Infectious Diseases NIH/DHHS (through interagency agreement Y1-AI-4894-01). 
