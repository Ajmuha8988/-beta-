// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', function () {
    const firstSelect = document.getElementById('first-select');
    const secondSelectContainer = document.getElementById('second-select-container');

    // Обработчик события изменения значения в первом select
    firstSelect.addEventListener('change', function (event) {
        if (event.target.value !== '') { // Если выбрано какое-то значение
            secondSelectContainer.style.display = 'block'; // Показываем второй select
        } else {
            secondSelectContainer.style.display = 'none'; // Скрываем второй select
        }
    });
});
    document.querySelector('.group-select').addEventListener('change', function () {
    document.getElementById('myForm').submit();
    });