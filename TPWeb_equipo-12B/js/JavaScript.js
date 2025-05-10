function mostrarModal(imagenUrl, nombre, descripcion, precio, id) {
    var modalImg = document.getElementById("modalImagen");
    var modalNombre = document.getElementById("modalNombre");
    var modalDescripcion = document.getElementById("modalDescripcion");
    var modalPrecio = document.getElementById("modalPrecio");
    var btnSeleccionar = document.getElementById("btnSeleccionar");

    modalImg.src = imagenUrl;
    modalNombre.textContent = nombre;
    modalDescripcion.textContent = descripcion;
    modalPrecio.textContent = precio;
    btnSeleccionar.dataset.productoId = id;
    $('#productoModal').modal('show');
}