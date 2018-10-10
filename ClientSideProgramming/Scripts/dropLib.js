function allowDrop(ev) {
	ev.preventDefault();
}

function drag(ev) {
	$("#delete").show();
	ev.dataTransfer.setData("text", ev.target.id);
}

function drop(ev) {
	ev.preventDefault();
	var id = ev.dataTransfer.getData("text");
	var element = document.getElementById(id);
	deleteFromDB(element);
	element.parentNode.removeChild(element);
	$("#delete").hide();
}