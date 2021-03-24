// Call the dataTables jQuery plugin
$(document).ready(function () {
    $('#dataTable').DataTable({
        info: false,
        lengthChange: false,
        searching: false
    });
});