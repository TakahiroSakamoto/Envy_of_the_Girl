using UnityEngine;

public class PlayerWalkSound : MonoBehaviour
{
    [SerializeField] private AudioClip[] m_FootstepSounds;
    private AudioSource m_AudioSource;
    private float _nowTime;
    private bool _isDash;
    [SerializeField] private GameObject dashCollider;
    [SerializeField] private GameObject walkController;
    [SerializeField] private GameObject secondDashCollider;



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
            }
        }
        else
        {
            _nowTime += Time.deltaTime;
            if (0.3f < _nowTime)
            {
                WalkSound();
                _nowTime = 0.0f;
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
        }
        else if (other.collider.gameObject.name == walkController.gameObject.name)
        {
            _isDash = false;
        } else if (other.collider.gameObject.name == secondDashCollider.name)
        {
            _isDash = true;
        }
    }


}