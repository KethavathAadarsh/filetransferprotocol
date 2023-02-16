// Get references to the textboxes and button
const sourceFilePathTextbox = document.getElementById('sourceFilePath') as HTMLInputElement;
const destinationFilePathTextbox = document.getElementById('destinationFilePath') as HTMLInputElement;
const transferButton = document.getElementById('transferButton') as HTMLButtonElement;

// Add a click event listener to the transfer button
transferButton.addEventListener('click', async () => {
    // Get the source and destination file paths from the textboxes
    const sourceFilePath = sourceFilePathTextbox.value;
    const destinationFilePath = destinationFilePathTextbox.value;

    // Send a POST request to the filetransfer.aspx file
    const response = await fetch('filetransfer.aspx', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            sourceFilePath,
            destinationFilePath
        })
    });

    // Display a message based on the response
    if (response.ok) {
        alert('File transfer successful!');
    } else {
        alert('File transfer failed.');
    }
});
