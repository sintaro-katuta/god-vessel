# MVP 武器・属性シード定義（初期データ案）

MVPで必要な「武器10本」「属性3種（炎/氷/雷）」の最小データ定義案。

## 属性（MVP）
- Fire
- Ice
- Lightning

## 属性反応（MVP）
1. **Frozen Shock**
   - 条件: `Ice` 付与中の対象に `Lightning` をヒット
   - 効果: 1.2秒行動不能 + 追加雷ダメージ
2. **Overheat Burst**
   - 条件: `Fire` スタック3到達
   - 効果: 小範囲爆発ダメージ

## 武器10本（シード）
| ID | 名前 | レア | 基礎攻撃 | 属性 | 固有効果 |
|---|---|---:|---:|---|---|
| WPN_001 | Ashfang | Common | 24 | Fire | 3ヒット毎に火傷1スタック |
| WPN_002 | Frostveil | Common | 22 | Ice | 弱攻撃で低確率スロウ |
| WPN_003 | Voltcarver | Common | 23 | Lightning | クリティカル時に微小連鎖 |
| WPN_004 | Ember Oath | Rare | 30 | Fire | ダッシュ攻撃で火傷2スタック |
| WPN_005 | Glacial Brand | Rare | 29 | Ice | 凍結中対象へ与ダメ+15% |
| WPN_006 | Storm Rite | Rare | 28 | Lightning | 3体まで連鎖雷 |
| WPN_007 | Cinder Hymn | Epic | 35 | Fire | Fire反応ダメージ+20% |
| WPN_008 | Hail Psalm | Epic | 34 | Ice | Ice付与時間+30% |
| WPN_009 | Arc Dominion | Epic | 34 | Lightning | Lightning付与時に攻速+10% |
| WPN_010 | Trinity Vessel | Legendary | 40 | None | 攻撃毎にFire/Ice/Lightning循環付与 |

## 融合ルール（MVP簡略）
- 素材2本から生成
- 継承枠:
  - メイン能力: ベース武器から1つ
  - サブ能力: 素材武器から1つ
  - 属性: Fire/Ice/Lightning のいずれか1つ
- 制限:
  - レアリティは最大 +1段階まで
  - Legendary は素材に Legendary が1本必要

## バランスの最初の仮説
- Common完凸 < Rare無凸 を維持
- 反応ビルド（属性連鎖）が単属性連打を上回るDPS
- ただし操作難度を要求して差別化
