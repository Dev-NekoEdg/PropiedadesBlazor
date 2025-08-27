using Microsoft.JSInterop;

namespace Propiedades.Helpers
{

    public enum ToastRType { 
    Success,
    Error,
    Warning,
    Info
    }

    public enum SweetAlertType
    {
        Success,
        Error,
        Warning,
        Info,
        Question
    }

    public static class JSHelper
    {
        private const string MethodToastR = "ShowToastR";
        private const string MethodSweetAlert = "ShowSweetAlert";


        private static string GetEnumName<T>(T type)
        {
            return Enum.GetName(typeof(T), type) ?? string.Empty;
        }

        #region ToastR

        public static async ValueTask HandlerToastR(this IJSRuntime jsRuntime, ToastRType toastType, string title, string message)
        {
            string getEnum = GetEnumName(toastType);
            await jsRuntime.InvokeVoidAsync(MethodToastR, getEnum?.ToLower(), title, message);        
        }

        public static async ValueTask ToastRSuccess(this IJSRuntime jsRuntime, string title, string message)
        {
            string getEnum = GetEnumName(ToastRType.Success);
            await jsRuntime.InvokeVoidAsync(MethodToastR, getEnum?.ToLower(), title, message);
        }

        public static async ValueTask ToastRError(this IJSRuntime jsRuntime, string title, string message)
        {
            string getEnum = GetEnumName(ToastRType.Error);
            await jsRuntime.InvokeVoidAsync(MethodToastR, getEnum?.ToLower(), title, message);
        }

        public static async ValueTask ToastRInfo(this IJSRuntime jsRuntime, string title, string message)
        {
            string getEnum = GetEnumName(ToastRType.Info);
            await jsRuntime.InvokeVoidAsync(MethodToastR, getEnum?.ToLower(), title, message);
        }

        public static async ValueTask ToastRWarning(this IJSRuntime jsRuntime, string title, string message)
        {
            string getEnum = GetEnumName(ToastRType.Warning);
            await jsRuntime.InvokeVoidAsync(MethodToastR, getEnum?.ToLower(), title, message);
        }

        #endregion

        #region SweetAlert

        public static async ValueTask HandlerSweetAlert(this IJSRuntime jsRuntime, SweetAlertType sweetAllewrtType, string title, string message)
        {
            string getEnum = GetEnumName(sweetAllewrtType);
            await jsRuntime.InvokeVoidAsync(MethodSweetAlert, getEnum?.ToLower(), title, message);
        }

        public static async ValueTask SweetAlertSuccess(this IJSRuntime jsRuntime, string title, string message)
        {
            string getEnum = GetEnumName(SweetAlertType.Success);
            await jsRuntime.InvokeVoidAsync(MethodSweetAlert, getEnum?.ToLower(), title, message);
        }

        public static async ValueTask SweetAlertError(this IJSRuntime jsRuntime, string title, string message)
        {
            string getEnum = GetEnumName(SweetAlertType.Error);
            await jsRuntime.InvokeVoidAsync(MethodSweetAlert, getEnum?.ToLower(), title, message);
        }

        public static async ValueTask SweetAlertWarning(this IJSRuntime jsRuntime, string title, string message)
        {
            string getEnum = GetEnumName(SweetAlertType.Warning);
            await jsRuntime.InvokeVoidAsync(MethodSweetAlert, getEnum?.ToLower(), title, message);
        }

        public static async ValueTask SweetAlertInfo(this IJSRuntime jsRuntime, string title, string message)
        {
            string getEnum = GetEnumName(SweetAlertType.Info);
            await jsRuntime.InvokeVoidAsync(MethodSweetAlert, getEnum?.ToLower(), title, message);
        }

        public static async ValueTask SweetAlertQuestion(this IJSRuntime jsRuntime, string title, string message)
        {
            string getEnum = GetEnumName(SweetAlertType.Question);
            await jsRuntime.InvokeVoidAsync(MethodSweetAlert, getEnum?.ToLower(), title, message);
        }

        #endregion

    }
}
