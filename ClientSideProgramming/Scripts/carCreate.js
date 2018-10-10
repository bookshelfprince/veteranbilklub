function CreateCar(formSubmitted) {
	var $form = $(formSubmitted).parents('form');
	var formData = {
		'Name': $('input[name=Name]').val(),
		'Year': $('input[name=Year]').val(),
		'Image': $('input[name=Image]').val(),
		'Manufactor': $('input[name=Manufactor]').val(),
	};
	if (formData.Image == null || formData.Manufactor == null || formData.Name == null || formData.Year == null)
		alert("Alle felter skal udfyldes");
	else
		var toInsert = '<div class="col-12 col-sm-6 col-lg-4 mt-1 d-flex align-items-stretch"> <div class="card" style="width:100%"> <img class="card-img-top" src="' + formData.Image + '" alt="Card image"> <div class="card-body"> <h4 class="card-title">' + formData.Name + '</h4> <p class="card-text">Fabrikant: ' + formData.Manufactor + '<br/>Årgang: ' + formData.Year + '</p> </div> </div> </div >';
	showpage('plusButton');
	$(toInsert).insertAfter(".posts");
}