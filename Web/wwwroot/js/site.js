// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Responsive Navbar
const toggleButton = document.getElementsByClassName('toggle-button')[0]
const navbarLinks = document.getElementsByClassName('navbar-links')[0]

toggleButton.addEventListener('click', () => {
    navbarLinks.classList.toggle('active')
})

// Modal Box

setTimeout(show_modal, 3000);

setTimeout(close_modal, 6000);


function show_modal() {
    var popup_box = document.getElementById('popup-box');
    popup_box.style.display = "block";
}
function close_modal() {
    var popup_box = document.getElementById('popup-box');
    popup_box.style.display = "none";
}

//// hidden course detail
//function hideDetails() {
//    var x = document.getElementById("template");
//    if (x.style.display === "none") {
//        x.style.display === "block";
//    }
//    else {
//        x.style.display === "none"
//    }
//}

