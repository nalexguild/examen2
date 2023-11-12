document.addEventListener("DOMContentLoaded", function () {
    // Realizar la solicitud (fetch) a la API para obtener la lista de libros
    fetch("http://localhost:5077/api/libros")
        .then(response => response.json())
        .then(data => {
            // Procesar los datos y agregar elementos a la tabla
            const librosTabla = document.getElementById("libros-lista");

            data.forEach(libro => {
                // Asegurarse de que el autor esté definido
                const autorNombre = libro.author ? libro.author.name : "Desconocido";

                // Crear la fila de la tabla
                const row = librosTabla.insertRow();

                // Agregar celdas a la fila con las propiedades del libro
                const celdas = [
                    libro.title,
                    autorNombre,
                    libro.chapters,
                    libro.pages,
                    libro.price
                ];

                celdas.forEach(valor => {
                    const cell = row.insertCell();
                    cell.textContent = valor;
                });
            });
        })
        .catch(error => console.error("Error al obtener la lista de libros:", error));
});
