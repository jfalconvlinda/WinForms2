using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Boleto : Form
    {
        public Boleto()
        {
            InitializeComponent();
        }

        // MÉTODO PARA VALIDAR QUE SOLO SEA NÚMEROS
        private bool IsNumber(string text)
        {
            return Regex.IsMatch(text, @"^[0-9]+$");
        }

        // MÉTODO PARA VALIDAR CARACTERES MÁXIMOS
        private bool ValidateLength(string text, int max)
        {
            return text.Length <= max;
        }

        // MÉTODO PARA VALIDAR OBLIGATORIO
        private bool Required(string text)
        {
            return !string.IsNullOrWhiteSpace(text);
        }

        // MÉTODO PARA OBTENER PRECIOS
        private int GetPrice(string tipo)
        {
            switch (tipo.ToLower())
            {
                case "nino": return 5;
                case "adulto": return 10;
                case "mayor": return 3;
                default: return 0;
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            // VALIDACIONES ------------------------

            if (!Required(txtNino.Text) || !Required(txtAdulto.Text) || !Required(txtTerceraEdad.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsNumber(txtNino.Text) || !IsNumber(txtAdulto.Text) || !IsNumber(txtTerceraEdad.Text))
            {
                MessageBox.Show("Solo se permiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateLength(txtNino.Text, 2) || !ValidateLength(txtAdulto.Text, 2) || !ValidateLength(txtTerceraEdad.Text, 2))
            {
                MessageBox.Show("Máximo 2 dígitos por campo (00 - 99).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // CONVERTIR CANTIDADES ------------------------
            int cantNino = Convert.ToInt32(txtNino.Text);
            int cantAdulto = Convert.ToInt32(txtAdulto.Text);
            int cantMayor = Convert.ToInt32(txtTerceraEdad.Text);

            // PRECIOS
            int precioNino = GetPrice("nino");
            int precioAdulto = GetPrice("adulto");
            int precioMayor = GetPrice("mayor");

            // SUBTOTALES
            int subNino = cantNino * precioNino;
            int subAdulto = cantAdulto * precioAdulto;
            int subMayor = cantMayor * precioMayor;

            // TOTAL
            int total = subNino + subAdulto + subMayor;

            txtTotal.Text = total.ToString();

            // MENSAJE FINAL
            MessageBox.Show(
                $"Detalle de compra:\n\n" +
                $"Niños: {cantNino} x ${precioNino} = ${subNino}\n" +
                $"Adultos: {cantAdulto} x ${precioAdulto} = ${subAdulto}\n" +
                $"Adulto Mayor: {cantMayor} x ${precioMayor} = ${subMayor}\n\n" +
                $"TOTAL: ${total}",
                "Compra realizada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
