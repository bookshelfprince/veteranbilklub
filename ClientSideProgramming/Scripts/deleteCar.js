function deleteFromDB(e) {
	// Child selection not working
	//var elements = $(e).children(".selected");
	var elements = e.childNodes;
	var name, year, image, manufactor;
	for (var i = 0; i < elements.length; i++) {
		if (elements[i].className == "modelName")
			name = elements[i].text();
		if (elements[i].className == "modelYear")
			year = elements[i].text();
		if (elements[i].className == "modelImage")
			image = elements[i].text();
		if (elements[i].className == "modelManufactor")
			manufactor = elements[i].text();
	}

	var car = new Object();
	car.Image = image;
	car.Name = name;
	car.Year = year;
	car.Manufactor = manufactor;

	if (car != null) {
		$.ajax({
			type: "POST",
			url: "/Home/DeleteCar",
			data: JSON.stringify(car),
			contentType: "application/json; charset=utf-8",
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