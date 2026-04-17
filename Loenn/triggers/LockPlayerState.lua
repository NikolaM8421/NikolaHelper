local LockPlayerState = {}

LockPlayerState.name = "NikolaHelper/LockPlayerState"
LockPlayerState.depth = 8998
LockPlayerState.nodeLimits = { 0, -1 }
LockPlayerState.nodeLineRenderType = "fan"
LockPlayerState.placements = {
    name = "normal",
    data = {
        lockState = true
    }
}

return LockPlayerState