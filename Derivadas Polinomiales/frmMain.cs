using System.Diagnostics;
using AngouriMath;
using CSharpMath.Forms;
using CSharpMath.SkiaSharp;
using SkiaSharp;

namespace Derivadas_Polinomiales
{
    public partial class frmMain : Form
    {
        Entity? mathExpression;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDerivar_Click(object sender, EventArgs e)
        {
            Entity derivative = mathExpression.Differentiate("x");
            Entity cleanedDerivative = derivative.Simplify(level: 2);
            txtResult.Text = cleanedDerivative.ToString();
            Debug.WriteLine(cleanedDerivative.Latexise());
            var painter = new MathPainter { LaTeX = cleanedDerivative.Latexise() };
            using var png = painter.DrawAsStream();
            Image image = Bitmap.FromStream(png);
            picResult.Image = image;
        }

        private void txtFuncion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mathExpression = txtFuncion.Text;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}