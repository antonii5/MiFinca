using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MiFinca.Clases
{
    /// <summary>
    /// Clase estática que contiene métodos para mostrar mensajes al usuario.
    /// <para>Tipos de mensajes: Toasts, Alertas, Confirmación y Loading.</para>
    /// </summary>
    public static class Notify
    {
        #region Toasts

        /// <summary>
        /// Muestra un mensaje de tipo Toast.
        /// </summary>
        /// <param name="message">Mensaje a mostrar.</param>
        public static void ShowToast(string message)
        {
            UserDialogs.Instance.Toast(message);
        }

        /// <summary>
        /// Muestra un mensaje de tipo Toast.
        /// </summary>
        /// <param name="message">Mensaje a mostrar.</param>
        /// <param name="time">Tiempo que se muestra</param>
        public static void ShowToast(string message, TimeSpan time)
        {
            UserDialogs.Instance.Toast(message, time);
        }

        #endregion

        #region Alerts

        /// <summary>
        /// Muestra un mensaje de tipo alert.
        /// </summary>
        /// <param name="message">Mensaje a mostrar</param>
        /// <param name="title">Título</param>
        /// <param name="btnText">Mensaje del botón</param>
        public static void ShowAlert(string message, string title, string btnCancelText)
        {
            UserDialogs.Instance.Alert(message, title, btnCancelText);
        }

        /// <summary>
        /// Muestra un mensaje de error de tipo alert.
        /// </summary>
        /// <param name="message"></param>
        public static void ShowAlert(string message)
        {
            UserDialogs.Instance.Alert(message, "Error", "Aceptar");
        }

        /// <summary>
        /// Muestra un mensaje de tipo alert.
        /// </summary>
        /// <param name="message">Mensaje a mostrar</param>
        /// <param name="title">Título</param>
        /// <param name="btnText">Mensaje del botón</param>
        public static async Task ShowAlertAsync(string message, string title, string btnCancelText)
        {
            await UserDialogs.Instance.AlertAsync(message, title, btnCancelText);
        }

        /// <summary>
        /// Muestra un mensaje de error de tipo alert.
        /// </summary>
        /// <param name="message">Mensaje a mostrar</param>
        public static async Task ShowAlertAsync(string message)
        {
            await UserDialogs.Instance.AlertAsync(message, "Error", "Aceptar");
        }

        /// <summary>
        /// Muestra un mensaje de tipo alert para confirmar una acción.
        /// </summary>
        /// <param name="message">Mensaje a mostrar</param>
        /// <param name="title">Título</param>
        /// <param name="btnOkText">Texto del botón aceptar</param>
        /// <param name="btnCancelText">Texto del botón cancelar</param>
        /// <returns>True si ha pulsado Aceptar, False si ha pulsado Cancelar.</returns>
        public static async Task<bool> ShowConfirmAsync(string message, string title, string btnCancelText, string btnOkText)
        {
            ConfirmConfig config = new ConfirmConfig
            {
                Message = message,
                Title = title,
                CancelText = btnCancelText,
                OkText = btnOkText
            };

            return await UserDialogs.Instance.ConfirmAsync(config);
        }



        /// <summary>
        /// Muestra una lista con los idiomas disponibles
        /// </summary>
        /// <param name="languages">Array strings con los idiomas disponibles</param>
        /// <param name="title">Título</param>
        /// <param name="btnText">Mensaje del botón</param>
        /* PENDIENTE IMPLEMENTACION
        public static async Task<String> SetLanguageAsync(string[] languages, string title, string btnCancelText)
        {
            string result = await UserDialogs.Instance.ActionSheetAsync(title, "", btnCancelText, null, languages);

            return result;
        }*/


        /// <summary>
        /// Pregunta contraseña actual al usuario   IMPLEMENTAR IGUAL QUE ELS ALTRES NOTIFY (NO A LO GUARRO JEJE)
        /// </summary>
        public static async Task<PromptResult> TypePassword()
        {
            PromptConfig pass_config = new PromptConfig();
            pass_config.SetCancellable(true);
            pass_config.SetOkText("Confirmar");
            pass_config.SetTitle("Confirmación contraseña");
            pass_config.SetInputMode(InputType.Password);

            return await UserDialogs.Instance.PromptAsync(pass_config);
        }
        #endregion

        #region Loading

        /// <summary>
        /// Muestra un icono de cargando con el mensaje "Cargando" 
        /// en el idioma correspondiente.
        /// </summary>
        public static void ShowLoading()
        {
            UserDialogs.Instance.ShowLoading("Cargando", MaskType.Clear);
        }

        /// <summary>
        /// Muestra un icono de cargando.
        /// </summary>
        /// <param name="message">Mensaje a mostrar</param>
        public static void ShowLoading(string message)
        {
            UserDialogs.Instance.ShowLoading(message, MaskType.Clear);
        }

        /// <summary>
        /// Oculta el icono de cargando.
        /// </summary>
        public static void HideLoading()
        {
            UserDialogs.Instance.HideLoading();
        }

        #endregion
    }
}
