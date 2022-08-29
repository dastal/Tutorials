var simon = document.getElementById("simon");
var simonPic = document.getElementById("simon-pc");
var bruce = document.getElementById("bruce");
var brucePic = document.getElementById("bruce-pc");
var ben = document.getElementById("ben");
var benPic = document.getElementById("ben-pc");


// not DRY
// simon.addEventListener("click", function() {
//     if (simonPic.className == "hide") {
//         simonPic.className = "";
//     } else {
//         simonPic.className = "hide";
//     }
// });

// bruce.addEventListener("click", function() {
//     if (bruce.className == "hide") {
//         bruce.className = "";
//     } else {
//         bruce.className = "hide";
//     }
// });

// ben.addEventListener("click", function() {
//     if (ben.className == "hide") {
//         ben.className = "";
//     } else {
//         ben.className = "hide";
//     }
// });


simon.addEventListener("click", picLink);
bruce.addEventListener("click", picLink);
ben.addEventListener("click", picLink);

function picLink() {
    var allImages = document.querySelectorAll("img");
    for (var i = 0; i<allImages.length; i++){
        allImages[i].className = "hide"
    }
    var picId = this.attributes["data-img"];
    var pic = document.getElementById(picId);
    if (pic.className == "hide") {
        pic.className = "";
    } else {
        pic.className = "hide";
    }
}