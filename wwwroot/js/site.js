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

function setId(id)
{
    const idInput = document.getElementById("annId");
    idInput.value = id;
}

function setIdRespond(id, isOffer)
{
    const idInput = document.getElementById("announId");
    idInput.value = id;
    const bool = document.getElementById("isoffer");
    bool.value = isOffer;
}

function setIdRespondToRespond(id)
{
    const idInput = document.getElementById("respId");
    idInput.value = id;
}

function setOffId(id)
{
    const idInput = document.getElementById("offId");
    idInput.value = id;
}

function filters()
{
    const radio = document.querySelector('input[name="grade"]:checked').value;
    const cards = document.getElementsByClassName("cardHid");

    let array = []
    let checkboxes = document.querySelectorAll('input[name=subject]:checked')

    for (var i = 0; i < checkboxes.length; i++) {
        array.push(checkboxes[i].value)
    }

    if (radio == "all") {
        for (let i = 0; i < cards.length; i++) {
            if (array.length > 0) {
                for (let j = 0; j < array.length; j++) {
                    if (cards[i].classList.contains("subject-" + array[j])) {
                        cards[i].style.display = "block";
                        break;
                    }
                    else {
                        cards[i].style.display = "none";
                    }
                }
            }
            else {
                cards[i].style.display = "block";
            }
        }
    }
    else {
        for (let i = 0; i < cards.length; i++) {
            if (cards[i].classList.contains("grade-" + radio)) {
                if (array.length > 0) {
                    for (let j = 0; j < array.length; j++) {
                        if (cards[i].classList.contains("subject-" + array[j])) {
                            cards[i].style.display = "block";
                            break;
                        }
                        else {
                            cards[i].style.display = "none";
                        }
                    }
                }
                else {
                    cards[i].style.display = "block";
                }
            }
            else {
                cards[i].style.display = "none";
            }
        }
    }

    return false;
}