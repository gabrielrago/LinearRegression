using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearRegression;
using MathNet.Numerics.LinearAlgebra;

namespace LinearRegression
{
    public partial class Form1 : Form
    {
        private DataTable advertisingData;

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            advertisingData = new DataTable();

            string filePath = @"C:\USERS\Gabriel\Downloads\Advertising.csv";

            using (var reader = new StreamReader(filePath))
            {
                // read the header row
                string[] headers = reader.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    advertisingData.Columns.Add(header, typeof(double));
                }

                // read the data rows
                while (!reader.EndOfStream)
                {
                    string[] values = reader.ReadLine().Split(',');
                    DataRow row = advertisingData.NewRow();

                    for (int i = 0; i < headers.Length; i++)
                    {
                        row[i] = double.Parse(values[i]);
                    }

                    advertisingData.Rows.Add(row);
                }
            }
        }

        private double PredictSales(double tvBudget, double radioBudget, double newspaperBudget)
        {
            // Build the input vector from the budgets
            Vector<double> input = Vector<double>.Build.DenseOfArray(new double[] { tvBudget, radioBudget, newspaperBudget });

            // Build the design matrix from the advertising data
            Matrix<double> design = Matrix<double>.Build.DenseOfRowArrays(
                advertisingData.AsEnumerable()
                    .Select(row => new double[] { row.Field<double>("TV"), row.Field<double>("Radio"), row.Field<double>("Newspaper") })
                    .ToArray()
            );

            // Build the response vector from the sales data
            Vector<double> response = Vector<double>.Build.DenseOfArray(advertisingData.AsEnumerable()
                .Select(row => row.Field<double>("Sales"))
                .ToArray()
            );

            // Perform the regression and return the predicted sales
            Vector<double> regressionResult = design.QR().Solve(response);
            double predictedSales = input.DotProduct(regressionResult);

            return predictedSales;
        }


        private void btnSolve_Click(object sender, EventArgs e)
        {
            double tvBudget = double.Parse(txtTvBudget.Text);
            double radioBudget = double.Parse(txtRadioBudget.Text);
            double newspaperBudget = double.Parse(txtNewspaperBudget.Text);

            double predictedSales = PredictSales(tvBudget, radioBudget, newspaperBudget);

            lblPredictedSales.Text = predictedSales.ToString("C2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
