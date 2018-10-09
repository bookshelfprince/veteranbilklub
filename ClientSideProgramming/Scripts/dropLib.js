function allowDrop(ev) {
	ev.preventDefault();
}

function drag(ev) {
	$("#delete").show();
	ev.dataTransfer.setData("id", ev.target.id);
}

function drop(ev) {
	ev.preventDefault();
	var id = ev.dataTransfer.getData("id");
	var element = document.getElementById(id);
	deleteFromDB(element);
	element.parentNode.removeChild(element);
	$("#delete").hide();
}