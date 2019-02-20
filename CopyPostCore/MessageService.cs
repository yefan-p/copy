using System.Windows.Forms;

namespace CopyPostCore
{
    public static class MessageService
    {
        /// <summary>
        /// Показать сообщение пользователю
        /// </summary>
        /// <param name="message">Текст для пользователя</param>
        public static void ShowMessage(string message)
        {
            MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Показать предупреждение пользователю
        /// </summary>
        /// <param name="message">Текст для пользователя</param>
        public static void ShowExclamation(string message)
        {
            MessageBox.Show(message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Показать ошибку пользователю
        /// </summary>
        /// <param name="message">Текст для пользователя</param>
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
