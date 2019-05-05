function confirmDelete(id) {
    let result = confirm("Are you sure?");
    if (result) {
        //make ajax call with jquery to delete without refresh
        $.ajax({
            url: `/department/delete/${id}`,
            type: "GET",
            success: function (res) {
                    //console.log(res); return html page of view page index
                if (res) {
                    console.log(res)
                    $(`#${id}`).remove();
                }
            },
            error: function (err) {
                console.log(err)
            }
        });


    }
}