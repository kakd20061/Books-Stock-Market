function switchTheme() {
    const icon = document.getElementById("theme");
    const navbar = document.getElementById("menu");
    if (icon.classList.contains("fa-moon")) {
        icon.classList.add("fa-sun");
        icon.classList.remove("fa-moon");
        navbar.classList.remove("bg-light")
        navbar.classList.remove("navbar-light")
        navbar.classList.add("bg-dark")
        navbar.classList.add("navbar-dark")
    }
    else {
        icon.classList.add("fa-moon");
        icon.classList.remove("fa-sun");
        navbar.classList.remove("navbar-dark")
        navbar.classList.remove("bg-dark")
        navbar.classList.add("navbar-light")
        navbar.classList.add("bg-light")
    }
}

function setId(id) {
    const idInput = document.getElementById("annId");
    idInput.value = id;
}

function setIdRespond(id,isOffer) {
    const idInput = document.getElementById("announId");
    idInput.value = id;
    const bool = document.getElementById("isoffer");
    bool.value = isOffer;
}

function setIdRespondToRespond(id) {
    const idInput = document.getElementById("respId");
    idInput.value = id;
}

function setOffId(id) {
    const idInput = document.getElementById("offId");
    idInput.value = id;
}