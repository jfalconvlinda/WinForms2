#include "mensaje_error".h
using namespace System;
using namespace System::Windows::Forms;
[STAThread]
void main(array<String^>^ arg)
{
	Application::EnableVisualStyles();

	Application::SetCompatibleTextRenderingDefault(false);
	// Crea una instancia de tu formulario principal y
	lo ejecuta
		WinFormsApp2::mensaje_errorForm form;
	Application::Run(% form);
}