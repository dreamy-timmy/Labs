#here we gonna do some main stuff
# 1) 11
# 2)
I = {1,2,3,4,5,6,7,8,9}
ribs = [[1,2], [1,5], [1,4], [2,3], [2,4], [2,5], [3,5], [3,6],
        [4,5], [4,7],[4,8], [5,6], [5,8], [5,9], [7,8], [8,9]]
weight = [15,14,23,19,16,15,14,26,25,23,20,24,27,18,14,18]
current = [i for i in weight]
sm = 0
tops = set()
# sm += min(weight)
# tops.add(ribs[weight.index(min(weight))][0])
# tops.add(ribs[weight.index(min(weight))][1])
# ribs.remove(ribs[weight.index(min(weight))])
# weight.remove(min(weight))


# while(True):
#     for i in range(len(weight)):
#         if weight[i] == min(current):
#             if (ribs[i][0] not in tops or ribs[i][1] not in tops) and (ribs[i][0] in tops or ribs[i][1] in tops):
#                 sm+=weight[i]
#                 print(weight[i],ribs[i][0],ribs[i][1],current,i)
#                 tops.add(ribs[i][0])
#                 tops.add(ribs[i][1])
#                 current.remove(weight[i])
#
#                 # current2 = [i for i in current if i!=min(current)]
#         # elif weight[i] == min(current2):
#             elif (ribs[i][0] in tops and ribs[i][1] in tops):
#                 print("Deleting", weight[i], tops, ribs[i][0], ribs[i][1], current, i)
#                 current.remove(weight[i])
#             elif ribs[i][0] not in tops and ribs[i][0] not in tops:
#                 current2 = [i for i in current if i != min(current)]
#                 ind = i
#                 while(ribs[i][0] not in tops and ribs[i][1] not in tops):
#                     if ind+1 <= len(weight)-1: ind += 1
#                     else: ind = 0
#                     if weight[ind] == min(current2):
#                         if (ribs[ind][0] not in tops or ribs[ind][1] not in tops) and (
#                                 ribs[ind][0] in tops or ribs[ind][1] in tops):
#                             sm += weight[ind]
#                             # print(weight[i], ribs[i][0], ribs[i][1], current, i)
#                             tops.add(ribs[ind][0])
#                             tops.add(ribs[ind][1])
#                             current2.remove(weight[ind])
#                             print(current2)
#                         elif (ribs[ind][0] in tops and ribs[ind][1] in tops):
#                             current2.remove(weight[ind])
#                 c = []
#                 current = [x for x in current if x in current2 or x == min(current)]
#             else: print(i)
#         if tops == I: f = 1
#     if f==1: break
#     # weight = [i for i in current]
# print(tops,sm,current)
index = 0
f = 1
a = b = 0
# while(weight):
#     if index + 1 <= len(weight) - 1:
#         index += 1
#     else:
#         index = 0
#     if f == 1:
#         if weight[index] == min(weight) and (ribs[index][0] not in tops or ribs[index][1] not in tops) and (ribs[index][0] in tops or ribs[index][1] in tops):
#             sm += weight[index]
#             # print(weight[i], ribs[i][0], ribs[i][1], current, i)
#             tops.add(ribs[index][0])
#             tops.add(ribs[index][1])
#             weight.remove(weight[index])
#             ribs.remove(ribs[index])
#         elif weight[index] == min(weight) and (ribs[index][0] in tops or ribs[index][1] in tops):
#             weight.remove(weight[index])
#             ribs.remove(ribs[index])
#         elif weight[index] == min(weight) and (ribs[index][0] not in tops and ribs[index][1] not in tops):
#             current = [weight[i] for i in range(len(weight)) if i != weight.index(min(weight))]
#             # print(min(weight),index)
#             f = 0
#             a = ribs[index][0]
#             b = ribs[index][1]
#     else:
#         if weight[index] == min(current) and (ribs[index][0] not in tops or ribs[index][1] not in tops) and \
#                 (ribs[index][0] in tops or ribs[index][1] in tops):
#             sm += weight[index]
#             tops.add(ribs[index][0])
#             tops.add(ribs[index][1])
#             weight.remove(weight[index])
#             ribs.remove(ribs[index])
#             current.remove(min(current))
#         elif weight[index] == min(current) and (ribs[index][0] in tops or ribs[index][1] in tops):
#             weight.remove(weight[index])
#             ribs.remove(ribs[index])
#             current.remove(min(current))
#         if a in tops or b in tops: f = 1
# print(sm)
# допилить с больше, чем 1 флагом, проверить на других заданиях
trash = []
tops.add(ribs[0][0])
while(weight):
    if index + 1 <= len(weight) - 1: index += 1
    else: index = 0
    mn_i = 0
    trash = 0
    f = 0
    for i in range(len(weight)):
        if (ribs[i][0] in tops or ribs[i][1] in tops) and (ribs[i][0] not in tops or ribs[i][1] not in tops):
            if weight[i] < weight[mn_i]:
                f = 1
                mn_i = i
        elif ribs[i][0] in tops and ribs[i][1] in tops: trash = i
    weight.remove(trash)
    print(weight,mn_i)
    if f:
        print(tops,weight,weight[mn_i],ribs[mn_i])
        tops.add(ribs[mn_i][0])
        tops.add(ribs[mn_i][1])
        sm += weight[mn_i]
        weight.remove(weight[mn_i])
        ribs.remove(ribs[mn_i])
    # print("!",trash,weight)
    # for i in range(len(trash)):
    #     # print(i,weight,trash)
    #     weight.remove(weight[trash[i]])
    #     ribs.remove(ribs[trash[i]])
    if tops == I: break
print(sm)

