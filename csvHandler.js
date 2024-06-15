const fs = require('fs');

// Read the CSV file
export function readCSV(CSV_PATH) {
    fs.readFile(CSV_PATH, 'utf8', (err, data) => {
        if (err) {
            console.error(err);
            return;
        }

        // Split the data into rows
        const rows = data.split('\n');

        // Process each row
        rows.forEach((row) => {
            // Split the row into columns
            const columns = row.split(',');

            // Process each column
            columns.forEach((column) => {
                // Do something with the column value
                console.log(column);
            });
        });
    });
}

