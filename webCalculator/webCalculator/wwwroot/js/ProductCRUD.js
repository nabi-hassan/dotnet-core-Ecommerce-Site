function addProdjs() {
    // Get the form data
    var formData = {
        ProdTitle: $('#ProdTitle').val(),
        ProdDescription: $('#ProdDescription').val(),
        ProdQuantity: $('#ProdQuantity').val(),
        ProdBrand: $('#ProdBrand').val(),
        ProdCategory: $('#ProdCategory').val(),
        ProdPrice: $('#ProdPrice').val()
    };

    // Send the data to the server
    $.ajax({
        type: 'POST',
        url: '/ProductsCRUD/AddProduct',
        data: formData,
        success: function (response) {
            // Update the view with the new data
            alert("Product Added Successfully.");
            window.location.href = "/ProductsCRUD/DisplayProduct";

        },
        error: function (response) {
            alert("Error: Can't Add Product");
        }
    });
}

function updateProdjs() {
    var formData = {
        ProdId: $('#ProdId').val(),
        ProdTitle: $('#ProdTitle').val(),
        ProdDescription: $('#ProdDescription').val(),
        ProdQuantity: $('#ProdQuantity').val(),
        ProdBrand: $('#ProdBrand').val(),
        ProdCategory: $('#ProdCategory').val(),
        ProdPrice: $('#ProdPrice').val()
    };
    alert(formData.ProdId);
    // Send the data to the server
    $.ajax({
        type: 'POST',
        url: "/ProductsCRUD/UpdateProductFinal",
        data: formData,
        success: function (response) {
            // Update the view with the new data
            alert("Product Added Successfully.");
            window.location.href = "/ProductsCRUD/DisplayProduct";

        },
        error: function (response) {
            alert("Error: Can't Add Product");
        }
    });
}

function DeleteProdjs() {
    var formData = {
        ProdId: $('#ProdId').val(),
        ProdTitle: $('#ProdTitle').val(),
        ProdDescription: $('#ProdDescription').val(),
        ProdQuantity: $('#ProdQuantity').val(),
        ProdBrand: $('#ProdBrand').val(),
        ProdCategory: $('#ProdCategory').val(),
        ProdPrice: $('#ProdPrice').val()
    };

    $.ajax({
        type: 'POST',
        url: "/ProductsCRUD/DeleteProduct",
        data: formData,
        success: function (response) {
            // Update the view with the new data
            alert("Product Deleted Successfully.");
            window.location.href = "/ProductsCRUD/DisplayProduct";

        },
        error: function (response) {
            alert("Error: Can't Delete Product");
        }
    });
}