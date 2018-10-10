function deleteFromDB(e) {
	var image, name, year, manufactor;
	//image = e.getElementsByClassName(".modelImage");
	image = e.getElementsByClassName('modelImage')[0].currentSrc;
	//year = $(e).children("card").children("card-body").children(".modelYear").text;
	//manufactor = $(e).children("card").children("card-body").children(".modelManufactor").text;

	if (image != null) {
		var dataToPost = {};
		dataToPost.image = image;
		$.ajax({
			type: "POST",
			url: "/Home/DeleteCar",
			data: JSON.stringify(dataToPost),
			contentType: "application/json;",
			dataType: "json",
			success: function (response) {
				// do nothing
			},
			failure: function (response) {
				// do nothing
			},
			error: function (response) {
				// do nothing
			}
		});
	};
}