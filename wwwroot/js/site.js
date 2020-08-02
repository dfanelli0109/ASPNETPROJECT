// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('.slider').slick({
        infinite: true,
        autoplay: true,
        dots: true,
        arrows: false,
        autoplaySpeed: 3000,
        slidesToShow: 1,
        slidesToScroll: 1
    });
});