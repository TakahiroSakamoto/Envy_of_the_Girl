using UnityEngine;

public class PlayerWalkSound : MonoBehaviour
{
    [SerializeField] private AudioClip[] m_FootstepSounds;
    [SerializeField] private AudioClip[] breathing;
    private AudioSource m_AudioSource;
    [SerializeField] private AudioSource brethAudio;
    private float _nowTime;
    private bool _isDash;
    [SerializeField] private GameObject dashCollider;
    [SerializeField] private GameObject walkController;
    [SerializeField] private GameObject secondDashCollider;

    [SerializeField] private GameObject dollTurn;




    // Use this for initialization
    private void Start()
    {
       m_AudioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    private void Update()
    {
        if (!_isDash)
        {
            _nowTime += Time.deltaTime;
            if (1.2f < _nowTime)
            {
                WalkSound();
                _nowTime = 0.0f;

                if (!brethAudio.isPlaying)
                {
                    brethAudio.clip = breathing[0];
                    brethAudio.PlayOneShot(brethAudio.clip);
                    print("StartAudio");
                }
            }
        }
        else
        {
            _nowTime += Time.deltaTime;
            if (0.3f < _nowTime)
            {
                WalkSound();
                _nowTime = 0.0f;

                if (!brethAudio.isPlaying)
                {
                    brethAudio.clip = breathing[1];
                    brethAudio.PlayOneShot(brethAudio.clip);
                    print("Dash!!");
                }
            }
        }
    }

    private void WalkSound()
    {
        int n = Random.Range(1, m_FootstepSounds.Length);
        m_AudioSource.clip = m_FootstepSounds[n];
        m_AudioSource.PlayOneShot(m_AudioSource.clip);
        m_FootstepSounds[n] = m_FootstepSounds[0];
        m_FootstepSounds[0] = m_AudioSource.clip;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.gameObject.name == dashCollider.gameObject.name)
        {
            _isDash = true;
            brethAudio.clip = breathing[1];
            brethAudio.PlayOneShot(brethAudio.clip);
            print("Dash!!");
        }
        else if (other.collider.gameObject.name == walkController.gameObject.name)
        {
            _isDash = false;
        } else if (other.collider.gameObject.name == secondDashCollider.gameObject.name)
        {
            _isDash = true;
            dollTurn.SetActive(true);
            Destroy(secondDashCollider.gameObject);
            print("DollTurn SetActive(true)");
        }
    }


}