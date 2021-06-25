var routeURL = location.protocol + "//" + location.host;
function openFeedBackWind() {
    $("#feedBackInput").modal("show");
}



function onCloseModal() {

    $("#feedBackInput").modal("hide");
}

function onSubmitForm() {
    var requestData = {
        Id: parseInt($("#id").val()),
        Comment: $("#comment").val(),
        Author: $("#author").val()
    };

    $.ajax({
        url: routeURL + '/FeedBack/SaveFeedBack',
        type: 'POST',
        data: JSON.stringify(requestData),
        contentType: 'application/json'

    });
    onCloseModal();
    alert('spasibo za otziv, brat');
}