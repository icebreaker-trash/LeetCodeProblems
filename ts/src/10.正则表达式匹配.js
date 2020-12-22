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
 * @param {string} s
 * @param {string} p
 * @return {boolean}
 */
var isMatch = function (s, p) {
  let result = false
  let si = 0
  let p1 = 0
  for (let i = 0; i < s.length; i++) {
    for (let pi = 0; pi < p.length; pi++) {
      if (p[pi] === '.') {
        if (checkNextisMul(pi, s)) {
        } else {
        }
      }
    }
  }

  return result
}

// @lc code=end
