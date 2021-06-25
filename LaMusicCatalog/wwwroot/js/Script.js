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



let filter = function () {
    let input = document.getElementById('filter-input');

    input.addEventListener('keyup', function () {
        let filter = input.value.toLowerCase(),
            filterElementsTr = document.querySelectorAll('.filter_items');
        console.log(filterElementsTr);
        filterElementsTr.forEach(item => {
            
            if (item.innerHTML.toLocaleLowerCase().indexOf(filter) > -1) {
            item.style.display = '';
            }
            else {
                item.style.display = 'none';
            }
        });
    });

}

filter();