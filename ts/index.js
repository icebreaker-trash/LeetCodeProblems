const path = require("path");
const fs = require("fs");
/**
 *
 * @param {String|Number} order
 */
function execute(order) {
  const dir = fs.readdirSync("./src");
  const str = dir.find((x) => x.startsWith(order.toString()));
  require(`./src/${str}`);
}
execute(10);