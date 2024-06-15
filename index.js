const csvReader = require('./csvHandler');

// Path to the CSV file
// process.argv[2] will be the first argument passed to your script
const CSV_PATH = process.argv[2] || '/path/to/your/default/file.csv';

function main() {
    // Read the CSV file
    csvReader.readCSV(CSV_PATH);
}

main();