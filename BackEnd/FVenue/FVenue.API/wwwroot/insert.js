$('#featureImageUpload').change(function () {
    console.log('event change')
})
console.log('scr');

const featureUploadElement = document.getElementById('featureImageUpload');
const featureImageUrlElement = document.getElementById('featureImageUrl');
const featureImageDisplayElement = document.getElementById('featureImageDisplay');

async function uploadFeatureImage(e) {
    console.log('go');
    let data = new FormData();

    console.log(e.target.files[0]);

    data.append('formFile', e.target.files[0]);
    await fetch('/API/VenuesAPI/ImageUpload', {
        method: 'POST',
        headers: {
            'Aceept': '*/*',
        },
        body: data
    }).then(response => response.json())
        .then(result => {
            featureImageUrlElement.value = result.url;
            featureImageDisplayElement.src = result.url;
            featureImageDisplayElement.style.display = 'block';
        });
}

$(function () {
    console.log("hi");
    uploadFeatureImage();
    document.getElementById('featureImageUpload').addEventListener('change', uploadFeatureImage);
});