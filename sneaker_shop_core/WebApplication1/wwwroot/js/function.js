function openNav(navId) {
    var slideBar = document.getElementById(navId);
    console.log(slideBar);
    slideBar.style.zIndex = "1";
    slideBar.style.opacity = "1";
    slideBar.style.transform = "none";
    slideBar.style.transition = "transform 0.3s ease-in-out 0s";
    var shadow = document.getElementById("ShadowLayer");
    shadow.style.opacity = "1";
    shadow.style.pointerEvents = "auto";
}
function closeNav(navId) {
    var slideBar = document.getElementById(navId);

    slideBar.style.zIndex = "0";
    slideBar.style.opacity = "0";
    slideBar.style.transform = "translate(100vw, 0px)";
    slideBar.style.transition =
        "opacity 0s linear 0.4s, transform 0.3s ease-in-out 0s";
    if (navId == "SlidingNav") {
        var shadow = document.getElementById("ShadowLayer");
        shadow.style.opacity = "0";
        shadow.style.pointerEvents = "none";
    }
}
function scrollToDetail() {
    var elmnt = document.getElementById("ProductDetail");
    elmnt.scrollIntoView();
}
function scrollXLeft(carouselId) {
    var slide = document.getElementById(carouselId);
    slide.scrollLeft += 300;
}
function scrollXRight(carouselId) {
    var slide = document.getElementById(carouselId);
    slide.scrollLeft -= 300;
}
function backToTop() {
    document.documentElement.scrollTop = 0;
}
function openSelection(selectionID) {
    var selection = document.getElementById(selectionID);
    if (selection.style.display == "block") {
        selection.style.display = "none";
    } else {
        selection.style.display = "block";
    }
}
function showForm(currentFormId, hiddenFormId) {
    var currentForm = document.getElementById(currentFormId);
    var hiddenForm = document.getElementById(hiddenFormId);
    currentForm.style.display = "none";
    hiddenForm.style.display = "block";
}
function showRecentSearchType(
    recentOptionId,
    otherRecentOptionId,
    recentBtnId,
    otherRecentBtnId
) {
    var recentOption = document.getElementById(recentOptionId);
    var otherRecentOption = document.getElementById(otherRecentOptionId);
    recentOption.style.display = "block";
    otherRecentOption.style.display = "none";
    document.getElementById(recentBtnId).style.borderBottom = "4px solid #0b0b0b";
    document.getElementById(otherRecentBtnId).style.borderBottom =
        "1px solid #0b0b0b";
}

function showFormWithAnimation(current, next) {
    var currentForm = document.getElementById(current);
    var nextForm = document.getElementById(next);
    nextForm.style.animation = "slideIn 0.4s cubic-bezier(0.37, 0.82, 0.2, 1)";
    currentForm.style.animation = "slideIn 0.4s cubic-bezier(0.37, 0.82, 0.2, 1)";
    currentForm.style.display = "none";
    nextForm.style.display = "block";
}
function showFormWithAnimationFlex(current, next) {
    var currentForm = document.getElementById(current);
    var nextForm = document.getElementById(next);
    nextForm.style.animation = "slideIn 0.4s cubic-bezier(0.37, 0.82, 0.2, 1)";
    currentForm.style.animation = "slideIn 0.4s cubic-bezier(0.37, 0.82, 0.2, 1)";
    currentForm.style.display = "none";
    nextForm.style.display = "flex";
}
