const uri = 'api/Countries';
let countries = [];

function getCountries() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayCountries(data))
        .catch(error => console.error('Unable to get categories.', error));
}

function addCountry() {
    const addNameTextbox = document.getElementById('add-name');

    const country = {
        name: addNameTextbox.value.trim()
    };

    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(country)
    })
        .then(response => response.json())
        .then(() => {
            getCountries();
            addNameTextbox.value = '';
            addInfoTextbox.value = '';
        })
        .catch(error => console.error('Unable to add country.', error));
}

function deleteCountry(id) {
    fetch(`${uri}/${id}`, {
        method: 'DELETE'
    })
        .then(() => getCountries())
        .catch(error => console.error('Unable to delete country.', error));
}

function displayEditForm(id) {
    const country = countries.find(country => country.id === id);

    document.getElementById('edit-id').value = country.id;
    document.getElementById('edit-name').value = country.name;
    document.getElementById('editForm').style.display = 'block';
}

function updateCountry() {
    const countryId = document.getElementById('edit-id').value;
    const country = {
        id: parseInt(countryId, 10),
        name: document.getElementById('edit-name').value.trim()
    };

    fetch(`${uri}/${countryId}`, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(country)
    })
        .then(() => getCountries())
        .catch(error => console.error('Unable to update country.', error));

    closeInput();

    return false;
}

function closeInput() {
    document.getElementById('editForm').style.display = 'none';
}


function _displayCountries(data) {
    const tBody = document.getElementById('countries');
    tBody.innerHTML = '';


    const button = document.createElement('button');

    data.forEach(country => {
        let editButton = button.cloneNode(false);
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', `displayEditForm(${country.id})`);

        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteCountry(${country.id})`);

        let tr = tBody.insertRow();


        let td1 = tr.insertCell(0);
        let textNode = document.createTextNode(country.name);
        td1.appendChild(textNode);

        let td3 = tr.insertCell(1);
        td3.appendChild(editButton);

        let td4 = tr.insertCell(2);
        td4.appendChild(deleteButton);
    });

    countries = data;
}
