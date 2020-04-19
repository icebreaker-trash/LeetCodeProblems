/*
 * @lc app=leetcode.cn id=2 lang=javascript
 *
 * [2] 两数相加
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */

function ListNode(val) {
  this.val = val;
  this.next = null;
}
/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */
var addTwoNumbers = function (l1, l2, add = 0) {
  if (l1 === null && l2 === null && add === 0) {
    return null;
  }
  let v = ((l1 && l1.val) || 0) + ((l2 && l2.val) || 0) + add;
  if (v > 9) {
    v = v - 10;
    add = 1;
  } else {
    add = 0;
  }
  const node = new ListNode(v);
  node.next = addTwoNumbers(l1 && l1.next, l2 && l2.next, add);
  return node;
};
// @lc code=end
