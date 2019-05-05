function confirmDelete(id) {
    let result = confirm("Are you sure?");
    if (result) {
        //location.href = `/employees/delete/${id}`;
        //make ajax call with jquery to delete without refresh
        $.ajax({
            url: `/employees/delete/${id}`,
            type: "GET",
            success: function (res) {
                //console.log(res); return html page of view page index
                if (res) {
                    $(`#${id}`).remove();
                }
            },
            error: function (err) {
                console.log(err)
            }
        });


    }
}