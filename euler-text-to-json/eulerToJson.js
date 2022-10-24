const fs = require('fs')
const path = require('path')

let euler = fs.readFileSync('task.txt')

euler = euler.toString().split('==========')

console.log('START ----------------')

const problemsJson = []

for (let index = 0; index < euler.length; index++) {
  const element = euler[index];
  const answer = element.split('Answer: ')[1]?.substring(0, 32)
  const text = element.split('Answer: ')[0].replaceAll('\r\n\r\n\r\n   ', '')

  problemsJson.push({ number: index + 1, text: text, answer: answer })
}

console.log(problemsJson)

fs.writeFile("output.json", JSON.stringify(problemsJson), 'utf8', function (err) {
  if (err) {
      console.log("An error occured while writing JSON Object to File.");
      return console.log(err);
  }

  console.log("JSON file has been saved.");
});