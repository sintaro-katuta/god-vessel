# Phase 0 実行チェックリスト（Unity基盤）

`docs/MVP_IMPLEMENTATION_PLAN.md` の Phase 0 を、実際に作業に着手できる粒度へ分解したチェックリスト。

## 0. ゴール
- ローカル1人プレイで `Hub -> Expedition -> Hub` が遷移できる。
- プレイヤーが移動/視点操作できる。
- データ駆動実装の最低限（ScriptableObject）を作る。

---

## 1. プロジェクト初期化
- [ ] Unity 6 LTS でプロジェクト作成（3D URP）
- [ ] ディレクトリ規約作成
  - `Assets/_Project/Scenes`
  - `Assets/_Project/Scripts`
  - `Assets/_Project/Data`
  - `Assets/_Project/Prefabs`
  - `Assets/_Project/Art`
- [ ] TextMeshPro / Input System 有効化
- [ ] Git管理対象外設定（Library, Temp など）

## 2. シーン設計
- [ ] `Title.unity` 作成
- [ ] `Hub.unity` 作成
- [ ] `Expedition.unity` 作成
- [ ] Build Settings へ3シーン登録
- [ ] Title -> Hub 遷移UIボタン
- [ ] Hub -> Expedition 出撃ポータル
- [ ] Expedition -> Hub 帰還ポータル

## 3. プレイヤー基礎
- [ ] FPSカメラ（マウス）
- [ ] WASD移動 + ダッシュ（Shift）
- [ ] ジャンプ（Space）
- [ ] スタミナ仮実装（消費/回復）
- [ ] 入力マップを `InputActions` として保存

## 4. 戦闘の土台（最小）
- [ ] 近接通常攻撃（左クリック）
- [ ] 攻撃時コリジョン判定
- [ ] ダメージイベント発火
- [ ] 敵ダミーへの被弾表示（ログ or フロートテキスト）

## 5. データ駆動の最小実装
- [ ] `WeaponData` ScriptableObject
- [ ] `SkillData` ScriptableObject
- [ ] `EnemyData` ScriptableObject
- [ ] `ReactionRuleData` ScriptableObject
- [ ] `FusionRuleData` ScriptableObject
- [ ] サンプルデータ投入（武器2、敵1、反応1）

## 6. 完了判定（DoD）
以下を満たしたら Phase 0 完了:
1. Title から Hub へ遷移できる。
2. Hub から Expedition へ出撃し、帰還できる。
3. Expedition 内で移動・視点・通常攻撃が行える。
4. ScriptableObjectのサンプルデータが読み込まれ、起動時エラーがない。

## 7. 見積り（初期）
- プロジェクト初期化: 0.5日
- シーン構築: 0.5日
- プレイヤー基礎: 1.0日
- 戦闘土台: 0.5日
- データ駆動: 0.5日
- バッファ（調整）: 0.5日

**合計: 約3.5営業日**

## 8. ブロッカー候補
- Input System設定漏れ（旧Inputとの競合）
- URP初期設定不足による描画崩れ
- シーン遷移時の依存参照切れ
