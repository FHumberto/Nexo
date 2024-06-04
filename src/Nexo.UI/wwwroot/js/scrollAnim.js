window.addEventListener('scroll', function () {
    let sections = document.querySelectorAll('.fade-in');
    let window_height = window.innerHeight;
    let window_top_position = window.pageYOffset;
    let window_bottom_position = (window_top_position + window_height);

    Array.prototype.forEach.call(sections, function (section) {
        let section_height = section.offsetHeight;
        let section_top_position = section.offsetTop;
        let section_bottom_position = (section_top_position + section_height);

        //? verifica se a section está na viewport
        if ((section_bottom_position >= window_top_position) &&
            (section_top_position <= window_bottom_position)) {
            section.classList.add('visible');
        } else {
            section.classList.remove('visible');
        }
    });
});