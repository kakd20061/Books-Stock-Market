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
$(function (e) { e.fn.blowup = function (o) { var s = this; if (s.is("img")) { var n = s.attr("src"), t = new Image; t.src = s.attr("src"); var r = e.extend({ round: !0, width: 200, height: 200, background: "#FFF", shadow: "0 8px 17px 0 rgba(0, 0, 0, 0.2)", border: "6px solid #FFF", cursor: !0, zIndex: 999999, scale: 1, customClasses: "" }, o); s.on("dragstart", function (e) { e.preventDefault() }), s.css("cursor", r.cursor ? "crosshair" : "none"); var a = document.createElement("div"); a.id = "BlowupLens", e("body").append(a), $blowupLens = e("#BlowupLens"), $blowupLens.css({ position: "absolute", display: "none", "pointer-events": "none", zIndex: r.zIndex, width: r.width, height: r.height, border: r.border, background: r.background, "border-radius": r.round ? "50%" : "none", "box-shadow": r.shadow, "background-repeat": "no-repeat" }), $blowupLens.addClass(r.customClasses), s.mouseenter(function () { $blowupLens.css("display", "block") }), s.mousemove(function (o) { var a = o.pageX - r.width / 2, i = o.pageY - r.height / 2, d = o.pageX - e(this).offset().left, c = o.pageY - e(this).offset().top, u = -Math.floor(d / s.width() * (t.width * r.scale) - r.width / 2) + "px " + -Math.floor(c / s.height() * (t.height * r.scale) - r.height / 2) + "px", l = t.width * r.scale + "px " + t.height * r.scale + "px"; $blowupLens.css({ left: a, top: i, "background-image": "url(" + encodeURI(n) + ")", "background-size": l, "background-position": u }) }), s.mouseleave(function () { $blowupLens.css("display", "none") }) } else console.log("%c Blowup.js Error: %cTarget element is not an image.", "background: #FCEBB6; color: #F07818; font-size: 17px; font-weight: bold;", "background: #FCEBB6; color: #F07818; font-size: 17px;") } });


function setDetails(url, title, price, description, grade, subject, email) {
    const imgUrl = document.getElementById('img');
    const dtitle = document.getElementById('dtitle');
    const dprice = document.getElementById('dprice');
    const ddescription = document.getElementById('ddescription');
    const dgrade = document.getElementById('dgrade');
    const dsubject = document.getElementById('dsubject');
    const dmail = document.getElementById('dmail');

    imgUrl.src = url;
    dtitle.innerText = title;
    dprice.innerText = price;
    ddescription.innerText = description;
    dgrade.innerText = grade;
    dsubject.innerText = subject;
    dmail.innerHTML = '<i class="fa-solid fa-phone"></i> '+email;

    $("#img").blowup({
        "width": 250,
        "height": 250
    });
}