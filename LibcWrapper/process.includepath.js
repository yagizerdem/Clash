import fs from "node:fs";
import path from "node:path";


const baseDir = process.argv[2] ?? (() => {
    throw new Error("Base directory not specified");
})();
const inputFile = process.argv[3] ?? (() => {
    throw new Error("Input file not specified");
})();
const outputFile = process.argv[4] ?? (() => {
    throw new Error("Output file not specified");
})(); 

const input = fs.readFileSync(inputFile, "utf8");

const absolutePaths = input
  .split(/\r?\n/)
  .map((line) => line.trim())
  .filter(Boolean)
  .map((file) => path.resolve(baseDir, file));

fs.writeFileSync(outputFile, absolutePaths.join("\n") + "\n");

console.log(`Converted ${absolutePaths.length} paths.`);