using System;
using SampSharp.GameMode;
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.Pools;
using SampSharp.GameMode.World;

namespace Grandlarc
{
    [PooledType]
    public class Player : BasePlayer
    {
        private static readonly Random Random = new Random();
        private DateTime _lastSelectionTime;
        public bool HasCitySelected;

        public Player()
        {
            SelectedCity = City.LosSantos;
        }

        public City SelectedCity { get; private set; }

        public override void OnConnected(EventArgs e)
        {
            base.OnConnected(e);

            Console.WriteLine(Name + " is connected.");

            SendClientMessage("Welcome to {88AA88}G{FFFFFF}rand {88AA88}L{FFFFFF}arceny");
            GameText("~w~Grand Larceny", 4000, 4);
        }

        public override void OnSpawned(SpawnEventArgs e)
        {
            base.OnSpawned(e);

            Interior = 0;

            var randomIndex = Random.Next(0, SpawnPositions.Positions[SelectedCity].Count);

            var randomPosition = SpawnPositions.Positions[SelectedCity][randomIndex];
            Position = randomPosition.Position;
            Rotation = new Vector3(randomPosition.Rotation);

            SetSkillLevel(WeaponSkill.Pistol, 200);
            SetSkillLevel(WeaponSkill.PistolSilenced, 200);
            SetSkillLevel(WeaponSkill.DesertEagle, 200);
            SetSkillLevel(WeaponSkill.Shotgun, 200);
            SetSkillLevel(WeaponSkill.SawnoffShotgun, 200);
            SetSkillLevel(WeaponSkill.Spas12Shotgun, 200);
            SetSkillLevel(WeaponSkill.MicroUzi, 200);
            SetSkillLevel(WeaponSkill.MP5, 200);
            SetSkillLevel(WeaponSkill.AK47, 200);
            SetSkillLevel(WeaponSkill.M4, 200);
            SetSkillLevel(WeaponSkill.SniperRifle, 200);

            GiveWeapon(Weapon.Colt45, 100);
            ToggleClock(false);
        }

        public override void OnDeath(DeathEventArgs e)
        {
            base.OnDeath(e);

            if (e.Killer != null && Money > 0)
            {
                e.Killer.Money += Money;
            }

            ResetMoney();
        }

        public override void OnRequestClass(RequestClassEventArgs e)
        {
            base.OnRequestClass(e);

            if (!HasCitySelected)
            {
                _lastSelectionTime = DateTime.Now;
                ToggleSpectating(true);

                GameMode.HelpSpawnTextdraw.Show(this);
                PrepareSelectedCity();

                e.PreventSpawning = true;
                return;
            }

            ShowCharacterSelection();
        }

        public override void OnUpdate(PlayerUpdateEventArgs e)
        {
            base.OnUpdate(e);

            if (State == PlayerState.Spectating && !HasCitySelected)
            {
                HandleCitySelection();
            }
        }

        private void HandleCitySelection()
        {
            GetKeys(out var keys, out _, out var leftright);

            if (keys == Keys.Fire)
            {
                ToggleSpectating(false);
                HasCitySelected = true;

                GameMode.HelpSpawnTextdraw.Hide(this);
                GameMode.LasVenturasTextDraw.Hide(this);
                GameMode.LosSantosTextDraw.Hide(this);
                GameMode.SanFierroTextDraw.Hide(this);
                return;
            }

            var now = DateTime.Now;

            if ((now - _lastSelectionTime).Milliseconds < 150)
            {
                return;
            }

            _lastSelectionTime = now;

            if (leftright < 0)
            {
                SelectedCity = SelectedCity.Next();
            }
            else if (leftright > 0)
            {
                SelectedCity = SelectedCity.Previous();
            }

            PrepareSelectedCity();
        }

        private void PrepareSelectedCity()
        {
            switch (SelectedCity)
            {
                case City.LosSantos:
                    Interior = 0;
                    CameraPosition = new Vector3(1630.6136f, -2286.0298f, 110.0f);
                    SetCameraLookAt(new Vector3(1887.6034f, -1682.1442f, 47.6167f));

                    GameMode.LasVenturasTextDraw.Hide(this);
                    GameMode.LosSantosTextDraw.Show(this);
                    GameMode.SanFierroTextDraw.Hide(this);
                    break;
                case City.SanFierro:
                    Interior = 0;
                    CameraPosition = new Vector3(-1300.8754f, 68.0546f, 129.4823f);
                    SetCameraLookAt(new Vector3(-1817.9412f, 769.3878f, 132.6589f));

                    GameMode.LasVenturasTextDraw.Hide(this);
                    GameMode.LosSantosTextDraw.Hide(this);
                    GameMode.SanFierroTextDraw.Show(this);
                    break;
                case City.LasVenturas:
                    Interior = 0;
                    CameraPosition = new Vector3(1310.6155f, 1675.9182f, 110.7390f);
                    SetCameraLookAt(new Vector3(2285.2944f, 1919.3756f, 68.2275f));

                    GameMode.LasVenturasTextDraw.Show(this);
                    GameMode.LosSantosTextDraw.Hide(this);
                    GameMode.SanFierroTextDraw.Hide(this);
                    break;
            }
        }

        private void ShowCharacterSelection()
        {
            switch (SelectedCity)
            {
                case City.LosSantos:
                    Interior = 11;
                    Position = new Vector3(508.7362f, -87.4335f, 998.9609f);
                    Angle = 0.0f;
                    CameraPosition = new Vector3(508.7362f, -83.4335f, 998.9609f);
                    SetCameraLookAt(new Vector3(508.7362f, -87.4335f, 998.9609f));
                    break;

                case City.SanFierro:
                    Interior = 3;
                    Position = new Vector3(-2673.8381f, 1399.7424f, 918.3516f);
                    Angle = 181.0f;
                    CameraPosition = new Vector3(-2673.2776f, 1394.3859f, 918.3516f);
                    SetCameraLookAt(new Vector3(-2673.8381f, 1399.7424f, 918.3516f));
                    break;

                case City.LasVenturas:
                    Interior = 3;
                    Position = new Vector3(349.0453f, 193.2271f, 1014.1797f);
                    Angle = 286.25f;
                    CameraPosition = new Vector3(352.9164f, 194.5702f, 1014.1875f);
                    SetCameraLookAt(new Vector3(349.0453f, 193.2271f, 1014.1797f));
                    break;
            }
        }
    }
}