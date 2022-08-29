var checklist = document.getElementById("checklist");

var items = checklist.querySelectorAll("li");
var inputs = checklist.querySelectorAll("input");

for (var i=0; i<items.length; i++) {
    items[i].addEventListener("click", editItem);
    // blur
    inputs[i].addEventListener("blur", updateItem);
    // event listener for key press
    inputs[i].addEventListener("keypress", itemKeypress);
}

// edit box 
function editItem() {
    this.className = "edit";
    var input = this.querySelector("input");
    input.focus();
    // full selection of the length
    input.setSelectionRange(0, input.value.length);
}

// go out of box
function updateItem() {
    this.previousElementSibling.innerHTML = this.value;
    // unfocus
    this.parentNode.className = "";
}

// go out of box by pressing enter
function itemKeypress(event) {
    //console.log(event.which);
    if (event.which == 13) {
        updateItem.call(this);
    }
}