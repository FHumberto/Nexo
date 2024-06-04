window.onscroll = function () { scrollFunction() };

function scrollFunction() {
    let backToTopButton = document.getElementById("backToTopButton");
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        backToTopButton.style.display = "block";
    } else {
        backToTopButton.style.display = "none";
    }
}

window.scrollToTopSmooth = function () {
    window.scrollTo({ top: 0, behavior: 'smooth' });
}
