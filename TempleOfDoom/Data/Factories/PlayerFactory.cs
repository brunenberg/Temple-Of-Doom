﻿using GameLogic.Entities;

namespace Data.Factories {
    public static class PlayerFactory {
        public static Player Create(PlayerDTO dto) {
            return new Player {
                CurrentRoomId = dto.startRoomId,
                X = dto.startX,
                Y = dto.startY,
                Lives = dto.lives
            };
        }

    }
}
