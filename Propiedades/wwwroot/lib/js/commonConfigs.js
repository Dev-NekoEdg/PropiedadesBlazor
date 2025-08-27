window.ShowToastR = (type, title, message) => {
    switch (type) {
        case "success":
            toastr.success(message, title, { timeOut: 5000, progressBar: true, });
            break;
        case "info":
            toastr.info(message, title, { timeOut: 5000, progressBar: true, });
            break;
        case "warning":
            toastr.warning(message, title, { timeOut: 5000, progressBar: true, });
            break;
        case "error":
            toastr.error(message, title, { timeOut: 5000, progressBar: true, });
            break;
        default:
            toastr.error(message, title, { timeOut: 5000, progressBar: true, });
            break;
    }
}

window.ShowSweetAlert = (type, title, message) => {
    switch (type) {
        case "success":
            Swal.fire({
                title: title,
                text: message,
                icon: "success"
            });
            break;
        case "error":
            Swal.fire({
                title: title,
                text: message,
                icon: "error"
            });
            break;
        case "warning":
            Swal.fire({
                title: title,
                text: message,
                icon: "warning"
            });
            break;
        case "info":
            Swal.fire({
                title: title,
                text: message,
                icon: "info"
            });
            break;
        case "question":
            Swal.fire({
                title: title,
                text: message,
                icon: "question"
            });
            break;
        default:
            Swal.fire({
                title: title,
                text: message,
                icon: "error"
            });
            break;
    }
}

