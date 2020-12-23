/*
 * @lc app=leetcode.cn id=10 lang=javascript
 *
 * [10] 正则表达式匹配
 */

// @lc code=start

/**
 * @param {number} index
 * @param {string} str
 */
const checkNextisMul = (index, str) => {
  const nextIdx = index + 1
  if (nextIdx < str.length) {
    return str[nextIdx] === '*'
  } else {
    return false
  }
}
/**
 * 连续的**，需要在之前就做处理，throw expection
 * @param {string} regexp
 */
const getMinMatchCount = (regexp) => {
  const l = regexp.length
  let mulCount = 0
  for (let i = 0; i < l; i++) {
    if (regexp[i] === '*') {
      mulCount++
    }
  }
  return l - mulCount * 2
}
/**
 * @param {string} str
 */
function checkFormatValid(str) {
  const l = str.length
  for (let i = 0; i < l; i++) {
    if (str[i] === '*') {
      if (i + 1 < l && str[i + 1] === '*') {
        return false
      }
    }
  }
  return true
}
class Compiler {
  /**
   * @param {String} str
   */
  constructor(str) {
    this.orginStr = str
    this.minMatchCount = getMinMatchCount(str)
    const checkList = []

    for (let i = 0; i < str.length; i++) {
      const flag = checkNextisMul(i, str)
      let j = i + 1
      if (flag) {
        j = i + 2
      }
      checkList.push({
        hasMul: flag,
        reg: str.substring(i, j)
      })
      if (flag) {
        i++
      }
    }
    this.checkList = checkList


  }
  /**
   * @param {string} target
   */
  test(target) {
    const rl = this.checkList.length
    const tl = target.length

    let tidx = 0
    let result = false
    while (tidx < tl) {
      let ridx = 0
      let nextIdx = tidx
      while (ridx < rl) {
        const regO = this.checkList[ridx]
        if (this.check(target(nextIdx), regO)) {
          if (regO.hasMul) {
            ridx++
          } else {
            nextIdx++
            ridx++
          }

        }
      }

      tidx++
    }
    return false
    //this.test()
  }
  /**
   * @typedef {Object} RegChar
   * @property {Boolean} hasMul
   * @property {string} reg
   * @param {string} char
   * @param {RegChar} regChar
   * 
   */
  check(char, regChar) {
    if (regChar.hasMul) {
      return true
    }
    let regText = regChar.reg
    if (regText[0] === char || regText[0] === '.') {
      return true
    } else {
      return false
    }
  }
}

/**
 * @param {string} s
 * @param {string} p
 * @return {boolean}
 */
var isMatch = function (s, p) {
  const compiler = new Compiler(p)
  compiler.test(s)
  console.log(compiler)
  //return result
}

isMatch('aa', 'a') //false
// isMatch('ab', '.*') //true
// isMatch('aab', 'c*a*b') //true
// isMatch('mississippi', 'mis*is*p*.') //false
// @lc code=end