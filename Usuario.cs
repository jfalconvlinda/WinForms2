using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Usuario : Form
    {
        // LISTA GLOBAL PARA GUARDAR USUARIOS BLOQUEADOS
        List<string> usuariosBloqueados = new List<string>();

        public Usuario()
        {
            InitializeComponent();
        }

        // INGRESAR NUEVO USUARIO
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            TablaInformacion.Rows.Add(
                txtid.Text,
                txtcedula.Text,
                txtcorreo.Text,
                txtnombre.Text,
                txtedad.Text,
                "Ingresado"   // Estado por defecto
            );

            // Limpiar TextBox
            txtid.Clear();
            txtcedula.Clear();
            txtcorreo.Clear();
            txtnombre.Clear();
            txtedad.Clear();

            txtid.Focus();
        }

        // ACTUALIZAR USUARIO
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (TablaInformacion.CurrentRow != null)
            {
                TablaInformacion.CurrentRow.Cells[0].Value = txtid.Text;
                TablaInformacion.CurrentRow.Cells[1].Value = txtcedula.Text;
                TablaInformacion.CurrentRow.Cells[2].Value = txtcorreo.Text;
                TablaInformacion.CurrentRow.Cells[3].Value = txtnombre.Text;
                TablaInformacion.CurrentRow.Cells[4].Value = txtedad.Text;

                MessageBox.Show("Información actualizada correctamente",
                                "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TablaInformacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = TablaInformacion.Rows[e.RowIndex];

                txtid.Text = row.Cells[0].Value?.ToString() ?? "";
                txtcedula.Text = row.Cells[1].Value?.ToString() ?? "";
                txtcorreo.Text = row.Cells[2].Value?.ToString() ?? "";
                txtnombre.Text = row.Cells[3].Value?.ToString() ?? "";
                txtedad.Text = row.Cells[4].Value?.ToString() ?? "";
            }
        }

        // CONSULTAR TODOS LOS USUARIOS
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (TablaInformacion.Rows.Count == 0)
            {
                MessageBox.Show("No existen usuarios registrados.",
                                "Consulta vacía",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewRow fila in TablaInformacion.Rows)
            {
                fila.Visible = true;
            }

            MessageBox.Show("Mostrando todos los usuarios registrados.",
                            "Consulta completada",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        // BUSCAR USUARIO
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string texto = (txtbuscar.Text ?? "").Trim().ToLower();

            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("Escribe un dato para buscar.");
                return;
            }

            bool encontrado = false;

            foreach (DataGridViewRow fila in TablaInformacion.Rows)
            {
                if (fila.IsNewRow) continue;

                string c0 = Convert.ToString(fila.Cells[0].Value)?.ToLower() ?? "";
                string c1 = Convert.ToString(fila.Cells[1].Value)?.ToLower() ?? "";
                string c2 = Convert.ToString(fila.Cells[2].Value)?.ToLower() ?? "";
                string c3 = Convert.ToString(fila.Cells[3].Value)?.ToLower() ?? "";
                string c4 = Convert.ToString(fila.Cells[4].Value)?.ToLower() ?? "";

                bool coincide =
                    c0.Contains(texto) ||
                    c1.Contains(texto) ||
                    c2.Contains(texto) ||
                    c3.Contains(texto) ||
                    c4.Contains(texto);

                if (coincide)
                {
                    fila.Selected = true;
                    TablaInformacion.FirstDisplayedScrollingRowIndex = fila.Index;
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontraron datos con ese texto.");
            }
        }

        // BLOQUEAR USUARIO
        private void btnbloquear_Click(object sender, EventArgs e)
        {
            if (TablaInformacion.CurrentRow != null)
            {
                string idBloqueado = TablaInformacion.CurrentRow.Cells[0].Value?.ToString() ?? "";
                string cedBloqueado = TablaInformacion.CurrentRow.Cells[1].Value?.ToString() ?? "";

                // Agregar ID
                if (!usuariosBloqueados.Contains(idBloqueado))
                    usuariosBloqueados.Add(idBloqueado);

                // Agregar CÉDULA
                if (!usuariosBloqueados.Contains(cedBloqueado))
                    usuariosBloqueados.Add(cedBloqueado);

                // Cambiar estado
                TablaInformacion.CurrentRow.Cells[5].Value = "Bloqueado";

                MessageBox.Show("Usuario bloqueado correctamente.");
            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            {
                string usuario = txtUsuario.Text.Trim();
                string contrasena = txtContrasena.Text.Trim();

                if (usuario == "" || contrasena == "")
                {
                    MessageBox.Show("Por favor ingresa usuario y contraseña.",
                                    "Campos vacíos",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }


                if (usuario == "Usuario" && contrasena == "Usuario1234")
                {
                    MessageBox.Show("Bienvenido " + usuario,
                                    "Acceso correcto",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    // Limpiar campos
                    txtUsuario.Clear();
                    txtContrasena.Clear();
                    return;
                }

                // VALIDAR SI EL USUARIO ESTÁ BLOQUEADO
                if (usuariosBloqueados.Contains(usuario))
                {
                    MessageBox.Show("Este usuario está bloqueado y no puede ingresar.",
                                    "Acceso denegado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                // Si no coincide con nada
                MessageBox.Show("Usuario o contraseña incorrectos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }


        }



        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
