let genre = document.getElementById('Movie_Genre');
//		genre.readOnly = true;
let genreList = document.getElementById('GenreList');
genreList.addEventListener('change',
    e => {
        if (genre.value === "") {
            genre.value = e.target.value;
        } else {
            genre.value += `, ${e.target.value}`;
        }
    });

//deleting one word at a time
genre.addEventListener('keyup', e => {
    let length = genre.value.lastIndexOf(", ");
    //backspace keycode = 8
    if (e.keyCode === 8) {
//        console.log(length);
//        console.log(genre.value.substring(0, length));
        genre.value = genre.value.substring(0, length);
    }
});

